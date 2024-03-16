using AspDotNet_MVC.Model.Entitis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspDotNet_MVC.Model.Configuration
{
    public class DonHangConfiguration : IEntityTypeConfiguration<DonHang>
    {
        public void Configure(EntityTypeBuilder<DonHang> builder)
        {
            builder.ToTable("DonHang");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.ThanhToans).WithMany(x => x.DonHangs).HasForeignKey(x => x.IdTT);
            builder.HasOne(x => x.Shippings).WithMany(x => x.DonHangs).HasForeignKey(x => x.IdDVVC);
        }
    }
}
