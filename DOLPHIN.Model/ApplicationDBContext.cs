using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace DOLPHIN.Model
{
    public class ApplicationDBContext : DbContext, IDbContext
    {
        private readonly bool isMemoryDatabase;
        public ApplicationDBContext(IConfiguration configurations, bool isMemoryDatabase = false)
        {
            this.Configs = configurations;
            this.isMemoryDatabase = isMemoryDatabase;
        }
        public virtual DbSet<HoSo> HoSo { get; set; }
        public virtual DbSet<DonViHanhChinh> DonViHanhChinh { get; set; }
        public virtual DbSet<CanBo> CanBo { get; set; }
        public virtual DbSet<HoSoQuet> HoSoQuet { get; set; }
        public virtual DbSet<LoaiChiPhi> LoaiChiPhi { get; set; }
        public virtual DbSet<ToChuc> ToChuc { get; set; }
        public virtual DbSet<ThongBao> ThongBao { get; set; }
        public virtual DbSet<MetaData> MetaData { get; set; }
        public virtual DbSet<QuanTrac> QuanTrac { get; set; }
        public virtual DbSet<BienBan> BienBan { get; set; }
        public virtual DbSet<ToTrinh> ToTrinh { get; set; }
        public virtual DbSet<SoHieu> SoHieu { get; set; }
        public virtual DbSet<SoGiaHan> SoGiaHan { get; set; }
        public virtual DbSet<CongTrinhKhaiThac> CongTrinhKhaiThac { get; set; }
        public virtual DbSet<Account> Account { get; set; }
        protected IConfiguration Configs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (this.isMemoryDatabase)
            {
                return;
            }

            if (!optionsBuilder.IsConfigured && this.Configs != null)
            {
                optionsBuilder.UseMySql(string.IsNullOrEmpty(this.Configs["ConnectionStrings:DBConnection"]) ? this.Configs.GetConnectionString("DBConnection") : this.Configs["ConnectionStrings:DBConnection"]);

                // optionsBuilder.UseSecondLevelCache();
            }
            //optionsBuilder
            //    .UseMySql("server=localhost;database=dolphin;user=root;password=;sslmode=none;")
            //    .UseLoggerFactory(LoggerFactory.Create(b => b
            //    .AddFilter(level => level >= LogLevel.Information)))
            //    .EnableSensitiveDataLogging()
            //    .EnableDetailedErrors();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SoHieuSoGiaHan>()
                .HasKey(c => new { c.MaSoHieu, c.MaSoGiaHan });
            modelBuilder.Entity<GiayPhepSoGiaHan>()
                .HasKey(c => new { c.MaGiayPhep, c.MaSoGiaHan });
            modelBuilder.Entity<ToChucSoGiaHan>()
                .HasKey(c => new { c.MaToChuc, c.MaSoGiaHan });
            //modelBuilder.Entity<ToTrinh>().HasIndex(c => c.Email).IsUnique();
            //modelBuilder.Entity<ToTrinh>().HasIndex(c => c.UserName).IsUnique();
        }
    }
}
