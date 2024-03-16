using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspDotNet_Data.Model.Entitis
{
    public class GioHang
    {
        public Guid Id { get; set; }
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public int Gia { get; set; }
        public Guid IdUser { get; set; }
        public virtual User Users { get; set; }
        public virtual ICollection<GioHangChiTiet> GioHangChiTiets { get; set; }

    }
}
