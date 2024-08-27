using DAMFINAL.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMFINAL.DAL.Repositories.Interface
{
    public interface IBuoiTroGiangRepo
    {
        string Create(Buoitrogiang btg);
        bool Delete(string code);
        List<Buoitrogiang> GetList();
        bool Update(Buoitrogiang btg);
    }
}
