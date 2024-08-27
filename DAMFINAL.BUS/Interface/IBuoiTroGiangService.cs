using DAMFINAL.BUS.ViewModel.BuoiTroGiangVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMFINAL.BUS.Interface
{
    public interface IBuoiTroGiangService
    {
        string Create(BuoiTroGiangCreateVM createVM);
        bool Delete(string code);
        List<BuoiTroGiangVM> GetList();
        bool Update(BuoiTroGiangUpdateVM updateVM);
    }
}
