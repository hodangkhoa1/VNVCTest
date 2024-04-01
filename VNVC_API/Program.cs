
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Filters;
using System.Reflection;
using System.Text.Json;
using VNVC_BAL.BackgroundServices;
using VNVC_BAL.Enums;
using VNVC_BAL.Services.Implements;
using VNVC_BAL.Services.Interfaces;
using VNVC_BAL.Utils;
using VNVC_DAL.Models;
using VNVC_DAL.Repositories.Implements;
using VNVC_DAL.Repositories.Interfaces;

namespace VNVC_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            string connectionString = FunctionSecurity.DecryptData(KeyConstants.KEY_DECRYPT_DATA, builder.Configuration.GetConnectionString("LocalConnection"));

            if (FunctionSecurity.CheckDbConnection(connectionString) == false)
            {
                connectionString = FunctionSecurity.DecryptData(KeyConstants.KEY_DECRYPT_DATA, builder.Configuration.GetConnectionString("ServerConnection"));
            }

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddSwaggerGen(s =>
            {
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                s.IncludeXmlComments(xmlPath);

                #region Authentication & Authorization
                s.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    Description = "Standard Authorization header using the Beare Scheme",
                    In = ParameterLocation.Header,
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey
                });

                s.OperationFilter<SecurityRequirementsOperationFilter>();
                #endregion
            });
            builder.Services.AddMvc().AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase);

            builder.Services.AddMvc().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });

            builder.Services.AddDbContext<VNVCContext>(options => options.UseSqlServer(connectionString));
            builder.Services.AddDistributedMemoryCache();
            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
            });

            #region Register Dependency Injection Repository
            builder.Services.AddScoped<IRepository<LotteryResults>, LotteryResultsRepository>();
            builder.Services.AddScoped<IRepository<UserLottery>, UserLotteryRepository>();
            builder.Services.AddScoped<IRepository<Account>, AccountRepository>();
            #endregion

            #region Register Dependency Injection Service
            builder.Services.AddScoped<IAccountService, AccountService>();
            builder.Services.AddScoped<ILotteryResultsService, LotteryResultsService>();
            builder.Services.AddScoped<IUserLotteryService, UserLotteryService>();
            #endregion

            /*#region Background Service
            builder.Services.AddHostedService<AddLotteryResultsBgService>();
            #endregion

            #region Add Scoped Background Service
            builder.Services.AddScoped<LotteryResultsRepository>();
            #endregion*/

            builder.Services.AddControllers().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);
            builder.Services.AddSwaggerGen();
            builder.Services.AddSignalR();

            builder.Services.Configure<KestrelServerOptions>(options =>
            {
                options.Limits.MaxRequestBodySize = int.MaxValue;
            });

            var app = builder.Build();

            app.UseSession();
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "VNVC API V1");
            });

            app.UseHttpsRedirection();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseWebSockets();

            app.MapControllers();

            app.Run();
        }
    }
}
