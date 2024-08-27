using DAMFINAL.BUS.Utils.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMFINAL.BUS.Utils
{
    public static class StatusTroGiang
    {
        public static string GetStatusNameTroGiang(this StatusEnumTroGiang trangThai)
        {
            return trangThai switch
            {
                StatusEnumTroGiang.DangLamViec => " 0 - Đang Làm Việc",
                StatusEnumTroGiang.DangNghiPhep => "1 - Đang Nghỉ Phép",
                StatusEnumTroGiang.NghỉViec => "2 - Nghỉ Việc",
                _ => "Không xác định"
            };
        }
    }
}
