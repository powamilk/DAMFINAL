using DAMFINAL.BUS.Utils.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMFINAL.BUS.Utils
{
    public static class StatusMonHoc
    {
        public static string GetStatusNameMonHoc(this StatusEnumMonHoc trangThai)
        {
            return trangThai switch
            {
                StatusEnumMonHoc.KhongConGiangDay => "0 - Không còn giảng dạy",
                StatusEnumMonHoc.DangGiangDay => "1 - Đang giảng dạy",
                StatusEnumMonHoc.TamNgungGiangDay => "2 - Tạm ngừng giảng dạy",
                _ => "Không xác định"
            };
        }
    }
}
