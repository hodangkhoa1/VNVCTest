using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using VNVC_BAL.Enums;
using VNVC_DAL.Models;
using VNVC_DAL.Repositories.Implements;

namespace VNVC_BAL.BackgroundServices
{
    public class AddLotteryResultsBgService(IServiceProvider services) : BackgroundService
    {
        private readonly IServiceProvider _services = services;
        private readonly Random random = new();
        private readonly List<TimeSpan> _checkTimes =
        [
            new TimeSpan(6, 13, 0)
        ];
        private readonly TimeSpan CurrentTime = DateTime.Now.TimeOfDay;

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                if (_checkTimes.Equals(CurrentTime))
                {
                    Console.WriteLine("Hello");
                    /*using var scope = _services.CreateScope();
                    var lotteryResultsRepository = scope.ServiceProvider.GetRequiredService<LotteryResultsRepository>();

                    var lotteryResults = new LotteryResults()
                    {
                        Result = random.Next(0, 9),
                        Slot = DateTime.Now,
                        InsertedDate = DateTime.Now,
                    };

                    await lotteryResultsRepository.ActionEdit(lotteryResults, ActionConstants.ACTION_ADD);*/
                }
            }

            await Task.Delay(TimeSpan.FromSeconds(10), stoppingToken);
        }
    }
}
