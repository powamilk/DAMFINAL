using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DAMFINAL.BUS.Utils.Status;

namespace DAMFINAL.BUS.Utils
{
    public static class StatusGiangVien
    {
        public static string GetStatusNameGiangVien(this StatusEnumGiangVien trangThai)
        {
            return trangThai switch
            {
                StatusEnumGiangVien.NghiHuu => "0 - Đã Nghỉ Hưu",
                StatusEnumGiangVien.DangLamViec => "1 - Đang Làm Việc",
                StatusEnumGiangVien.DangNghiPhep => "2 - Đang Nghỉ Phép",
                _ => "Không xác định"
            };
        }
    }
}
