using DAMFINAL.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAMFINAL.DAL.Repositories.Interface
{
    public interface IThongKeRepo
    {
        List<Giangvien> GetGiangViensWithMonHocCount();
        List<Monhoc> GetMonHocsWithTroGiangCount();
        List<Trogiang> GetTroGiangsWithBuoiTroGiangCount();
        List<Buoitrogiang> GetBuoiTroGiangsByStatus(int trangThai);
        List<Giangvien> GetGiangViensByStatus(int trangThai);
        List<Trogiang> GetTroGiangsByStatus(int trangThai);

    }
}
