using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAMFINAL.BUS.ViewModel.GiangVienVM;

namespace DAMFINAL.BUS.Interface
{
    public interface IGiangVienService
    {
        List<GiangVienVM> GetList();
        string Create(GiangVienCreateVM createVM);
        bool Update(GiangVienUpdateVM updateVM);
        bool Delete(string code);

    }
}
