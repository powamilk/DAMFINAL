using DAMFINAL.BUS.ViewModel.ThongKeVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMFINAL.BUS.Interface
{
    public interface IThongKeService
    {
        List<GiangVienThongKeVM> GetThongKeGiangVien();
        List<MonHocThongKeVM> GetThongKeMonHoc();
        List<TroGiangThongKeVM> GetThongKeTroGiang();
        ThongKeTheoTrangThaiVM GetThongKeTrangThai(int trangThai);
    }
}
