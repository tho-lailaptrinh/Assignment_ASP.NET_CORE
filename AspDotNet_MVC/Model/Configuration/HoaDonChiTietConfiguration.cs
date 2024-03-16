using AspDotNet_Data.Model.Entitis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspDotNet_MVC.Model.Configuration
{
    public class HoaDonChiTietConfiguration : IEntityTypeConfiguration<HoaDonChiTiet>
    {
        public void Configure(EntityTypeBuilder<HoaDonChiTiet> builder)
        {
            builder.ToTable("HoaDonChiTiet");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.MoTa).HasMaxLength(200);
            builder.Property(x => x.TenSP).IsRequired().HasMaxLength(100);

            builder.HasOne(x => x.SanPhams).WithMany(x => x.HoaDonChiTiets).HasForeignKey(x => x.IdSP);
            builder.HasOne(x => x.HoaDons).WithMany(x => x.HoaDonChiTiets).HasForeignKey(x => x.IdHD);
        }
    }
}
