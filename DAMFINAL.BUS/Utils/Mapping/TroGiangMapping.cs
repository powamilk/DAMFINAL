using DAMFINAL.BUS.ViewModel.TroGiangVM;
using DAMFINAL.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMFINAL.BUS.Utils.Mapping
{
    public static class TroGiangMapping
    {
        public static Trogiang MapCreateVMToEntity(TroGiangCreateVM vm)
        {
            return new Trogiang
            {
                Matg = vm.Matg,
                Tentg = vm.Tentg,
                Ngaysinh = vm.Ngaysinh,
                Diachi = vm.Diachi,
                Trangthai = vm.Trangthai
            };
        }

        public static TroGiangVM MapEntityToVM(Trogiang entity)
        {
            return new TroGiangVM
            {
                Matg = entity.Matg,
                Tentg = entity.Tentg,
                Ngaysinh = entity.Ngaysinh,
                Diachi = entity.Diachi,
                Trangthai = entity.Trangthai
            };
        }

        public static Trogiang MapUpdateVMToEntity(TroGiangUpdateVM vm)
        {
            return new Trogiang
            {
                Matg = vm.Matg,
                Tentg = vm.Tentg,
                Ngaysinh = vm.Ngaysinh,
                Diachi = vm.Diachi,
                Trangthai = vm.Trangthai
            };
        }
    }
}
