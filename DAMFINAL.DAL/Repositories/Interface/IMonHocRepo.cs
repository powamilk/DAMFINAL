using DAMFINAL.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMFINAL.DAL.Repositories.Interface
{
    public interface IMonHocRepo
    {
        string Create(Monhoc monHoc); 
        bool Delete(string code);
        List<Monhoc> GetList();
        bool Update(Monhoc monHoc); 
    }
}
