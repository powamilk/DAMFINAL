using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAMFINAL.DAL.Entities;

namespace DAMFINAL.DAL.Repositories.Interface
{
    public interface IGiangVienRepo
    {
        List<Giangvien> GetList();
        List<Giangvien> GetListByName(string name);
        string Create(Giangvien gv);
        bool Update(Giangvien gv);
        bool Delete(string code);
    }
}
