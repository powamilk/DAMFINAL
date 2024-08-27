using DAMFINAL.BUS.ViewModel.MonHocVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMFINAL.BUS.Interface
{
    public interface IMonHocService
    {
        string Create(MonHocCreateVM createVM);
        bool Delete(string code);
        List<MonHocVM> GetList();
        bool Update(MonHocUpdateVM updateVM);
    }
}
