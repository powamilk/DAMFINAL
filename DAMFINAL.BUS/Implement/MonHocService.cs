using DAMFINAL.BUS.Interface;
using DAMFINAL.BUS.Utils.Mapping;
using DAMFINAL.BUS.ViewModel.MonHocVM;
using DAMFINAL.DAL.Entities;
using DAMFINAL.DAL.Repositories.Implement;
using DAMFINAL.DAL.Repositories.Interface;
using DAMFINAL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMFINAL.BUS.Implement
{
    public class MonHocService : IMonHocService
    {
        private readonly IMonHocRepo _repo;
        private readonly AppDbContext _appDbContext;

        public MonHocService()
        {
            _repo = new MonHocRepo();
            _appDbContext = new AppDbContext();
        }

        public string Create(MonHocCreateVM createVM)
        {
            var allMonHocs = _repo.GetList();
            var lastMaMH = allMonHocs
                .Select(mh => mh.Mamh)
                .OrderByDescending(ma => ma)
                .FirstOrDefault();

            int lastNumber = int.Parse(lastMaMH.Substring(2));
            int newNumber = lastNumber + 1;
            string generatedMaMH = "MH" + newNumber.ToString("D3");

            Monhoc entity = MonHocMapping.MapCreateVMToEntity(createVM, generatedMaMH);
            var result = _repo.Create(entity);
            return result;
        }

        public bool Delete(string code)
        {
            var result = _repo.Delete(code);
            return result;
        }

        public List<MonHocVM> GetList()
        {
            List<Monhoc> entities = _repo.GetList();
            var vms = entities.Select(e => MonHocMapping.MapEntityToVM(e)).ToList();
            return vms;
        }

        public bool Update(MonHocUpdateVM updateVM)
        {
            Monhoc entity = MonHocMapping.MapUpdateVMToEntity(updateVM);
            var result = _repo.Update(entity);
            return result;
        }
    }
}
