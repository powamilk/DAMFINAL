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
    public class BuoiTroGiangRepo : IBuoiTroGiangRepo
    {
        private readonly AppDbContext _appDbContext;

        public BuoiTroGiangRepo()
        {
            _appDbContext = new AppDbContext();
        }

        public string Create(Buoitrogiang btg)
        {
            try
            {
                _appDbContext.Add(btg);
                _appDbContext.SaveChanges();
                return "Thêm Thành Công Buổi Trợ Giảng";
            }
            catch (Exception ex)
            {
                return $"Thêm Thất Bại\nLỗi: {ex.Message}";
            }
        }

        public bool Delete(string code)
        {
            try
            {
                var queryable = _appDbContext.Buoitrogiangs.AsQueryable();
                Buoitrogiang buoiTroGiang = queryable.FirstOrDefault(e => e.Mabtg == code);

                if (buoiTroGiang != null)
                {
                    _appDbContext.Remove(buoiTroGiang);
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

        public List<Buoitrogiang> GetList()
        {
            var queryable = _appDbContext.Buoitrogiangs.AsQueryable()
                .Include(btg => btg.MamhNavigation)
                .Include(btg => btg.MatgNavigation);

            return queryable.ToList();
        }

        public bool Update(Buoitrogiang btg)
        {
            try
            {
                var queryable = _appDbContext.Buoitrogiangs.AsQueryable();
                Buoitrogiang buoiTroGiang = queryable.FirstOrDefault(e => e.Mabtg == btg.Mabtg);

                if (buoiTroGiang != null)
                {
                    buoiTroGiang.Sothutu = btg.Sothutu;
                    buoiTroGiang.Trangthai = btg.Trangthai;
                    buoiTroGiang.Mamh = btg.Mamh;
                    buoiTroGiang.Matg = btg.Matg;

                    _appDbContext.Update(buoiTroGiang);
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
