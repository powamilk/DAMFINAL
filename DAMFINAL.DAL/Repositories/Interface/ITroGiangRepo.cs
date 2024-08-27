using DAMFINAL.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMFINAL.DAL.Repositories.Interface
{
    public interface ITroGiangRepo
    {
        string Create(Trogiang troGiang);
        bool Delete(string matg);
        List<Trogiang> GetList();
        bool Update(Trogiang troGiang);
    }
}
