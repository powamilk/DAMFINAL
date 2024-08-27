using DAMFINAL.BUS.ViewModel.BuoiTroGiangVM;
using DAMFINAL.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMFINAL.BUS.Utils.Mapping
{
    public static class BuoiTroGiangMapping
    {
        public static Buoitrogiang MapCreateVMToEntity(BuoiTroGiangCreateVM createVM, string generatedMaBTG)
        {
            return new Buoitrogiang
            {
                Mabtg = generatedMaBTG,
                Sothutu = createVM.Sothutu,
                Trangthai = createVM.Trangthai,
                Mamh = createVM.Mamh,
                Matg = createVM.Matg
            };
        }

        public static BuoiTroGiangVM MapEntityToVM(Buoitrogiang entity)
        {
            return new BuoiTroGiangVM
            {
                Mabtg = entity.Mabtg,
                Sothutu = entity.Sothutu ?? 0,
                Trangthai = entity.Trangthai ?? 0,
                Mamh = entity.Mamh,
                MonHocName = entity.MamhNavigation?.Tenmh ?? "Không xác định",
                Matg = entity.Matg,
                TroGiangName = entity.MatgNavigation?.Tentg ?? "Không xác định"
            };
        }

        public static Buoitrogiang MapUpdateVMToEntity(BuoiTroGiangUpdateVM updateVM)
        {
            return new Buoitrogiang
            {
                Mabtg = updateVM.Mabtg,
                Sothutu = updateVM.Sothutu,
                Trangthai = updateVM.Trangthai,
                Mamh = updateVM.Mamh,
                Matg = updateVM.Matg
            };
        }
    }
}
