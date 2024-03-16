using AspDotNet_Data.Model.Entitis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspDotNet_Data.Model.Configuration
{
    public class HoaDonConfiguration : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.ToTable("HoaDon");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Users).WithMany(x => x.HoaDons).HasForeignKey(x => x.IdUser);
            builder.HasOne(x => x.DonHangs).WithMany(x => x.HoaDons).HasForeignKey(x => x.IdDH);

        }
    }
}
