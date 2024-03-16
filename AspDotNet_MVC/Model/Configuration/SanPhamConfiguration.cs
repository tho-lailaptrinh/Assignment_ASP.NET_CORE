using AspDotNet_Data.Model.Entitis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspDotNet_MVC.Model.Configuration
{
    public class SanPhamConfiguration : IEntityTypeConfiguration<SanPham>
    {
        public void Configure(EntityTypeBuilder<SanPham> builder)
        {
            builder.ToTable("SanPham");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Ten).IsRequired().HasMaxLength(120);
            builder.Property(x => x.MoTa).HasMaxLength(200);
            builder.HasOne(x => x.DanhMucSanPhams).WithMany(x => x.SanPhams).HasForeignKey(x => x.IdDMSP);
        }
    }
}
