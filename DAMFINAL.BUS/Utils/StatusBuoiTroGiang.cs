using DAMFINAL.BUS.Utils.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMFINAL.BUS.Utils
{
    public static class StatusBuoiTroGiang
    {
        public static string GetStatusName(this StatusEnumBuoiTroGiang trangThai)
        {
            return trangThai switch
            {
                StatusEnumBuoiTroGiang.DaHuy => "0 - Đã hủy",
                StatusEnumBuoiTroGiang.DaDienRa => "1 - Đã diễn ra",
                StatusEnumBuoiTroGiang.DangDienRa => "2 - Đang diễn ra",
                _ => "Không xác định"
            };
        }
    }
}
