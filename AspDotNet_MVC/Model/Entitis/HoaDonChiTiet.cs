using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspDotNet_Data.Model.Entitis
{
    public class HoaDonChiTiet
    {
        public Guid Id { get; set; }
        public string TenSP { get; set; }
        public double Gia { get; set; }
        public int SoLuong { get; set; }
        public string MoTa { get; set; }
        public DateTime NgayTao { get; set; }
        public Guid IdSP { get; set; }
        public virtual SanPham SanPhams { get; set; }
        public Guid IdHD {get; set;}
        public virtual HoaDon HoaDons { get; set; }

    }
}
