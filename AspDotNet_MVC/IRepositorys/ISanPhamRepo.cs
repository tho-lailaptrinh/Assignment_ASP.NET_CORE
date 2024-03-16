using AspDotNet_Data.Model.Entitis;

namespace AspDotNet_MVC.IRepositorys
{
    public interface ISanPhamRepo
    {
        public IEnumerable<SanPham> GetSanPhams();
        public Task<SanPham> CreateSP(SanPham sp);
        public Task<SanPham> UpdateSP(Guid id,SanPham sp);
        public Task<SanPham> DeleteSP(Guid id);  


    }
}
