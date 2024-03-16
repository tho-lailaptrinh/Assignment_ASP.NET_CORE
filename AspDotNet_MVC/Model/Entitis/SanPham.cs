using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspDotNet_Data.Model.Entitis
{
    public class SanPham
    {
        public Guid Id { get; set; }
        public string Ten { get; set; }
        public int Gia { get; set; }
        public int SoLuong { get; set; }
        public string MoTa { get; set; }
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public virtual ICollection<GioHangChiTiet> GioHangChiTiets { get; set; }
    }
}
