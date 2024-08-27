using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMFINAL.BUS.ViewModel.GiangVienVM
{
    public class GiangVienUpdateVM
    {
        public string Magv { get; set; } = null!;

        public string? Tengv { get; set; }

        public DateOnly? Ngaysinh { get; set; }

        public string? Diachi { get; set; }

        public int? Trangthai { get; set; }
    }
}
