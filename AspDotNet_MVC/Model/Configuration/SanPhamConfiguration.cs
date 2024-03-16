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
        }
    }
}
