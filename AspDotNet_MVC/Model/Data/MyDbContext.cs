using AspDotNet_Data.Model.Configuration;
using AspDotNet_Data.Model.Entitis;
using AspDotNet_MVC.Model.Configuration;
using Microsoft.EntityFrameworkCore;

namespace AspDotNet_Data.Model.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
        {
            
        }
        public MyDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public DbSet<GioHang> GioHangs { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<GioHangChiTiet> GioHangChiTiets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new GioHangConfiguration());
            modelBuilder.ApplyConfiguration(new GioHangChiTietConfiguration());
            modelBuilder.ApplyConfiguration(new HoaDonConfiguration());
            modelBuilder.ApplyConfiguration(new HoaDonChiTietConfiguration());
            modelBuilder.ApplyConfiguration(new SanPhamConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
