using AspDotNet_Data.Model.Entitis;

namespace AspDotNet_MVC.Model.Entitis
{
    public class DanhMucSanPham
    {
        public Guid Id { get; set; }
        public string TenDM { get; set; }
        public string MoTa { get; set; }
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
