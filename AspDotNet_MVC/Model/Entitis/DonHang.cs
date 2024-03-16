using AspDotNet_Data.Model.Entitis;

namespace AspDotNet_MVC.Model.Entitis
{
    public class DonHang
    {
        public Guid Id { get; set; }
        public DateTime NgayTao { get; set; }
        public int TrangThai { get; set; }

        public Guid IdTT { get; set; }
        public virtual ThanhToan ThanhToans { get; set; }

        public Guid IdDVVC { get; set; }
        public virtual Shipping Shippings { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
