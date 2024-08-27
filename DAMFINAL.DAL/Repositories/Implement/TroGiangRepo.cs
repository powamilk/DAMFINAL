using DAMFINAL.DAL.Entities;
using DAMFINAL.DAL.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMFINAL.DAL.Repositories.Implement
{
    public class TroGiangRepo : ITroGiangRepo
    {
        private readonly AppDbContext _appDbContext;

        public TroGiangRepo()
        {
            _appDbContext = new AppDbContext();
        }

        public string Create(Trogiang troGiang)
        {
            try
            {
                _appDbContext.Trogiangs.Add(troGiang);
                _appDbContext.SaveChanges();
                return "Thêm Thành Công Trợ Giảng";
            }
            catch (Exception ex)
            {
                return "Thêm Thất Bại\n" + $"Lỗi: {ex}";
            }
        }

        public bool Delete(string matg)
        {
            try
            {
                var troGiang = _appDbContext.Trogiangs.FirstOrDefault(tg => tg.Matg == matg);
                if (troGiang != null)
                {
                    _appDbContext.Trogiangs.Remove(troGiang);
                    _appDbContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public List<Trogiang> GetList()
        {
            return _appDbContext.Trogiangs.ToList();
        }

        public bool Update(Trogiang troGiang)
        {
            try
            {
                var existingTroGiang = _appDbContext.Trogiangs.FirstOrDefault(tg => tg.Matg == troGiang.Matg);
                if (existingTroGiang != null)
                {
                    existingTroGiang.Tentg = troGiang.Tentg;
                    existingTroGiang.Ngaysinh = troGiang.Ngaysinh;
                    existingTroGiang.Diachi = troGiang.Diachi;
                    existingTroGiang.Trangthai = troGiang.Trangthai;

                    _appDbContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
