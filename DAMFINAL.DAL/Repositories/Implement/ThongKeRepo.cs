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
    public class ThongKeRepo : IThongKeRepo
    {
        AppDbContext _appDbContext;

        public ThongKeRepo()
        {
            _appDbContext = new AppDbContext();
        }

        public List<Giangvien> GetGiangViensWithMonHocCount()
        {
            return _appDbContext.Giangviens
                .Include(gv => gv.Monhocs)
                .ToList();
        }

        public List<Monhoc> GetMonHocsWithTroGiangCount()
        {
            return _appDbContext.Monhocs
                .Include(mh => mh.Buoitrogiangs)
                .Include(mh => mh.MagvNavigation)
                .ToList();
        }

        public List<Trogiang> GetTroGiangsWithBuoiTroGiangCount()
        {
            return _appDbContext.Trogiangs
                .Include(tg => tg.Buoitrogiangs)
                .ToList();
        }

        public List<Buoitrogiang> GetBuoiTroGiangsByStatus(int trangThai)
        {
            return _appDbContext.Buoitrogiangs
                .Where(bt => bt.Trangthai == trangThai)
                .ToList();
        }

        public List<Giangvien> GetGiangViensByStatus(int trangThai)
        {
            return _appDbContext.Giangviens
                .Where(gv => gv.Trangthai == trangThai)
                .ToList();
        }

        public List<Trogiang> GetTroGiangsByStatus(int trangThai)
        {
            return _appDbContext.Trogiangs
                .Where(tg => tg.Trangthai == trangThai)
                .ToList();
        }

    }
}
