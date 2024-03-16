using AspDotNet_Data.Model.Data;
using AspDotNet_Data.Model.Entitis;
using AspDotNet_MVC.IRepositorys;

namespace AspDotNet_MVC.Repositorys
{
    public class SanPhamRepo : ISanPhamRepo
    {
        private readonly MyDbContext _context;
        public SanPhamRepo()
        {
            _context = new MyDbContext();
        }
        public IEnumerable<SanPham> GetSanPhams()
        {
             return _context.SanPhams.ToList();
        }
        public async Task<SanPham> CreateSP(SanPham sp)
        {
            SanPham sanpham = new SanPham()
            {
                Ten = sp.Ten,
                Gia = sp.Gia,
                SoLuong = sp.SoLuong,
                MoTa = sp.MoTa,
            };
            _context.SanPhams.Add(sanpham);
             await _context.SaveChangesAsync();
            return sanpham;
        }
        public Task<SanPham> UpdateSP(Guid id, SanPham sp)
        {
            throw new NotImplementedException();
        }
        public Task<SanPham> DeleteSP(Guid id)
        {
            throw new NotImplementedException();
        }

    }
}
