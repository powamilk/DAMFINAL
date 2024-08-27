using DAMFINAL.BUS.ViewModel.GiangVienVM;
using DAMFINAL.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMFINAL.BUS.Utils.Mapping
{
    public class GiangVienMapping
    {
        public static GiangVienVM MapEntityToVM(Giangvien entity)
        {
            return new()
            {
                Magv = entity.Magv,
                Tengv = entity.Tengv,
                Diachi = entity.Diachi,
                Trangthai = entity.Trangthai
            };
        }

        public static Giangvien MapCreateVMToEntity(GiangVienCreateVM createVM)
        {
            return new()
            {
                Magv = createVM.Magv,
                Tengv = createVM.Tengv,
                Diachi = createVM.Diachi,
                Trangthai = createVM.Trangthai
            };
        }

        public static Giangvien MapUpdateVMToEntity(GiangVienUpdateVM updateVM)
        {
            return new()
            {
                Magv = updateVM.Magv,
                Tengv = updateVM.Tengv,
                Diachi = updateVM.Diachi,
                Trangthai = updateVM.Trangthai
            };
        }
    }
}
