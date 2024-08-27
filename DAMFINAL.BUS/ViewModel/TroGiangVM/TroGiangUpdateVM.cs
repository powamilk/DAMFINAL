using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMFINAL.BUS.ViewModel.TroGiangVM
{
    public class TroGiangUpdateVM
    {
        public string Matg { get; set; } = null!;

        public string? Tentg { get; set; }

        public DateOnly? Ngaysinh { get; set; }

        public string? Diachi { get; set; }

        public int? Trangthai { get; set; }
    }
}
