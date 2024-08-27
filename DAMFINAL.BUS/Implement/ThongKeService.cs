using DAMFINAL.BUS.Interface;
using DAMFINAL.BUS.ViewModel.ThongKeVM;
using DAMFINAL.DAL;
using DAMFINAL.DAL.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAMFINAL.DAL.Repositories.Implement;

namespace DAMFINAL.BUS.Implement
{
    public class ThongKeService : IThongKeService
    {
        private readonly IThongKeRepo _thongKeRepo;
        private readonly AppDbContext _appDbContext;

        public ThongKeService()
        {
            _thongKeRepo = new ThongKeRepo();
            _appDbContext = new AppDbContext();
        }

        public List<GiangVienThongKeVM> GetThongKeGiangVien()
        {
            var giangViens = _thongKeRepo.GetGiangViensWithMonHocCount();
            return giangViens.Select(gv => new GiangVienThongKeVM
            {
                Magv = gv.Magv,
                Tengv = gv.Tengv,
                SoLuongMonHoc = gv.Monhocs.Count,
                TongSoTinChi = gv.Monhocs.Sum(mh => mh.Sotinchi ?? 0)
            }).ToList();
        }

        public List<MonHocThongKeVM> GetThongKeMonHoc()
        {
            var monHocs = _thongKeRepo.GetMonHocsWithTroGiangCount();
            return monHocs.Select(mh => new MonHocThongKeVM
            {
                Mamh = mh.Mamh,
                Tenmh = mh.Tenmh,
                GiangVienPhuTrach = $"{mh.Magv} - {mh.MagvNavigation?.Tengv}",
                SoLuongBuoiTroGiang = mh.Buoitrogiangs.Count
            }).ToList();
        }

        public List<TroGiangThongKeVM> GetThongKeTroGiang()
        {
            var troGiangs = _thongKeRepo.GetTroGiangsWithBuoiTroGiangCount();
            return troGiangs.Select(tg => new TroGiangThongKeVM
            {
                Matg = tg.Matg,
                Tentg = tg.Tentg,
                SoLuongBuoiTroGiang = tg.Buoitrogiangs.Count,
                SoLuongBuoiTroGiangDangThamGia = tg.Buoitrogiangs.Count(bt => bt.Trangthai == 2)
            }).ToList();
        }

        public ThongKeTheoTrangThaiVM GetThongKeTrangThai(int trangThai)
        {
            var giangViens = _thongKeRepo.GetGiangViensByStatus(trangThai);
            var troGiangs = _thongKeRepo.GetTroGiangsByStatus(trangThai);
            var buoiTroGiangs = _thongKeRepo.GetBuoiTroGiangsByStatus(trangThai);

            return new ThongKeTheoTrangThaiVM
            {
                SoLuongGiangVien = giangViens.Count,
                SoLuongTroGiang = troGiangs.Count,
                SoLuongBuoiTroGiang = buoiTroGiangs.Count
            };
        }
    }
}
