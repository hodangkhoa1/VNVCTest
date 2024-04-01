using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace VNVC_DAL.Models;

public partial class VNVCContext : DbContext
{
    private static readonly string KEY = "b14ca5898a4e4133bbce2ea2315a1916";

    public VNVCContext()
    {
    }

    public VNVCContext(DbContextOptions<VNVCContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Account { get; set; }

    public virtual DbSet<LotteryResults> LotteryResults { get; set; }

    public virtual DbSet<UserLottery> UserLottery { get; set; }

    private static string DecryptString(string key, string cipherText)
    {
        byte[] iv = new byte[16];
        byte[] buffer = Convert.FromBase64String(cipherText);

        using Aes aes = Aes.Create();
        aes.Key = Encoding.UTF8.GetBytes(key);
        aes.IV = iv;
        ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

        using MemoryStream memoryStream = new(buffer);
        using CryptoStream cryptoStream = new(memoryStream, decryptor, CryptoStreamMode.Read);
        using StreamReader streamReader = new(cryptoStream);
        return streamReader.ReadToEnd();
    }

    private static bool CheckDbConnection(string connectionString)
    {
        try
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                return true;
            }
        }
        catch (Exception)
        {
            return false;
        }
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            IConfiguration config = new ConfigurationBuilder()
                                        .SetBasePath(Directory.GetCurrentDirectory())
                                        .AddJsonFile("appsettings.json").Build();

            string connectionString = DecryptString(KEY, config["ConnectionStrings:LocalConnection"]);

            if (CheckDbConnection(connectionString) == false)
            {
                connectionString = DecryptString(KEY, config["ConnectionStrings:ServerConnection"]);
            }

            optionsBuilder.UseSqlServer(connectionString);
        }

        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.AccountID).HasName("PK__Account__349DA58628F91969");

            entity.Property(e => e.AccountID).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ColorAvatar)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DefaultAvatar)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.FullName).HasMaxLength(250);
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LotteryResults>(entity =>
        {
            entity.HasKey(e => e.LotteryResultsID).HasName("PK__LotteryR__13C107F13CD83DBC");

            entity.Property(e => e.LotteryResultsID).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<UserLottery>(entity =>
        {
            entity.HasKey(e => e.UserLotteryID).HasName("PK__UserLott__4E7936E098335A70");

            entity.Property(e => e.UserLotteryID).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Account).WithMany(p => p.UserLottery)
                .HasForeignKey(d => d.AccountID)
                .HasConstraintName("FK__UserLotte__Accou__2B3F6F97");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
