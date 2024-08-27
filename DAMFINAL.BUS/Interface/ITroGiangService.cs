using DAMFINAL.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAMFINAL.BUS.ViewModel.TroGiangVM;

namespace DAMFINAL.BUS.Interface
{
    public interface ITroGiangService
    {
        string Create(TroGiangCreateVM createVM);
        bool Delete(string matg);
        List<TroGiangVM> GetList();
        bool Update(TroGiangUpdateVM updateVM);
    }
}
