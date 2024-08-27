using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAMFINAL.BUS.Interface;
using DAMFINAL.BUS.ViewModel.TroGiangVM;
using DAMFINAL.DAL.Entities;
using DAMFINAL.DAL.Repositories.Interface;
using DAMFINAL.BUS.Utils.Mapping;
using DAMFINAL.DAL.Repositories.Implement;
using DAMFINAL.DAL;

namespace DAMFINAL.BUS.Implement
{
    public class TroGiangService : ITroGiangService
    {
        private readonly ITroGiangRepo _repo;
        private readonly AppDbContext _appDbContext;

        public TroGiangService()
        {
            _repo = new TroGiangRepo();
            _appDbContext = new AppDbContext();
        }

        public string Create(TroGiangCreateVM createVM)
        {
            Trogiang entity = TroGiangMapping.MapCreateVMToEntity(createVM);
            var result = _repo.Create(entity);
            return result;
        }

        public bool Delete(string matg)
        {
            var result = _repo.Delete(matg);
            return result;
        }

        public List<TroGiangVM> GetList()
        {
            List<Trogiang> entities = _repo.GetList();
            var vms = entities.Select(e => TroGiangMapping.MapEntityToVM(e)).ToList();
            return vms;
        }

        public bool Update(TroGiangUpdateVM updateVM)
        {
            Trogiang entity = TroGiangMapping.MapUpdateVMToEntity(updateVM);
            var result = _repo.Update(entity);
            return result;
        }
    }
}
