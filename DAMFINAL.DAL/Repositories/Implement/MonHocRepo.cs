using DAMFINAL.DAL.Entities;
using DAMFINAL.DAL.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMFINAL.DAL.Repositories.Implement
{
    public class MonHocRepo : IMonHocRepo
    {
        AppDbContext _appDbContext;

        public MonHocRepo()
        {
            _appDbContext = new AppDbContext();
        }

        public string Create(Monhoc monHoc)
        {
            try
            {
                _appDbContext.Add(monHoc);
                _appDbContext.SaveChanges();
                return "Thêm Thành Công Môn Học";
            }
            catch (Exception ex)
            {
                return "Thêm Thất Bại\n" + $"Lỗi: {ex.Message}";
            }
        }

        public bool Delete(string code)
        {
            try
            {
                var queryable = _appDbContext.Monhocs.AsQueryable();
                Monhoc monHoc = queryable.FirstOrDefault(e => e.Mamh == code);

                if (monHoc != null)
                {
                    _appDbContext.Remove(monHoc);
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

        public List<Monhoc> GetList()
        {
            var monHocs = _appDbContext.Monhocs
                   .Include(mh => mh.MagvNavigation) 
                   .ToList();

            return monHocs;
        }
        public bool Update(Monhoc monHoc)
        {
            try
            {
                var queryable = _appDbContext.Monhocs.AsQueryable();
                Monhoc existingMonHoc = queryable.FirstOrDefault(e => e.Mamh == monHoc.Mamh);

                if (existingMonHoc != null)
                {
                    existingMonHoc.Tenmh = monHoc.Tenmh;
                    existingMonHoc.Sotinchi = monHoc.Sotinchi;
                    existingMonHoc.Trangthai = monHoc.Trangthai;
                    existingMonHoc.Magv = monHoc.Magv;

                    _appDbContext.Update(existingMonHoc);
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
