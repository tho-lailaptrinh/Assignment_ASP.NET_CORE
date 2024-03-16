using AspDotNet_Data.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspDotNet_Data.Model.Entitis
{
    public class HoaDon
    {
        public Guid Id { get; set; }
        public decimal TongTien { get; set; }
        public DateTime NgayTao { get; set; } // ngày bán
        public int Status { get; set; } // trạng thái
        public Guid IdUser { get; set; }
        public virtual User Users { get; set; }
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
