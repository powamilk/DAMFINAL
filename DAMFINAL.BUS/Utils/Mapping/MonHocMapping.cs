using DAMFINAL.BUS.ViewModel.MonHocVM;
using DAMFINAL.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMFINAL.BUS.Utils.Mapping
{
    public static class MonHocMapping
    {
        public static MonHocVM MapEntityToVM(Monhoc entity)
        {
            return new MonHocVM
            {
                Mamh = entity.Mamh,
                Tenmh = entity.Tenmh,
                Sotinchi = entity.Sotinchi ?? 0,
                Trangthai = entity.Trangthai ?? 0,
                GiangVienName = entity.MagvNavigation?.Tengv,
                Magv = entity.Magv
            };
        }

        public static Monhoc MapCreateVMToEntity(MonHocCreateVM vm, string generatedMaMH)
        {
            return new Monhoc
            {
                Mamh = generatedMaMH,
                Tenmh = vm.Tenmh,
                Sotinchi = vm.Sotinchi,
                Trangthai = vm.Trangthai,
                Magv = vm.Magv
            };
        }

        public static Monhoc MapUpdateVMToEntity(MonHocUpdateVM vm)
        {
            return new Monhoc
            {
                Mamh = vm.Mamh,
                Tenmh = vm.Tenmh,
                Sotinchi = vm.Sotinchi,
                Trangthai = vm.Trangthai,
                Magv = vm.Magv
            };
        }
    }
}
