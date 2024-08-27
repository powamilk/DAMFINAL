using DAMFINAL.DAL.Entities;
using DAMFINAL.DAL.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMFINAL.DAL.Repositories.Implement
{
    public class GiangVienRepo : IGiangVienRepo
    {
        AppDbContext _appDbContext;
        public GiangVienRepo()
        {
            _appDbContext = new();
        }
        public string Create(Giangvien gv)
        {
            try
            {
                _appDbContext.Add(gv);
                _appDbContext.SaveChanges();
                return "Thêm Thành Công Giảng Viên";
            }
            catch (Exception ex)
            {
                return "Thêm Thất Bại\n" + $"Lỗi: {ex}";
            }
                
        }

        public bool Delete(string code)
        {
            try
            {
                var queryable = _appDbContext.Giangviens.AsQueryable();
                Giangvien giangVien = queryable.FirstOrDefault(e => e.Magv == code);

                _appDbContext.Remove(giangVien);
                _appDbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Giangvien> GetList()
        {
            var queryable = _appDbContext.Giangviens.AsQueryable();
            List<Giangvien> giangviens = queryable.ToList();
            return giangviens;
        }

        public List<Giangvien> GetListByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool Update(Giangvien gv)
        {
            try
            { 
                var queryable = _appDbContext.Giangviens.AsQueryable();
                Giangvien giangvien = queryable.FirstOrDefault(e => e.Magv == gv.Magv);

                giangvien.Tengv = gv.Tengv;
                giangvien.Diachi = gv.Diachi;
                giangvien.Ngaysinh = gv.Ngaysinh;
                giangvien.Trangthai = gv.Trangthai;

                _appDbContext.Update(giangvien);
                _appDbContext.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
