using DAMFINAL.BUS.Interface;
using DAMFINAL.BUS.Utils.Mapping;
using DAMFINAL.BUS.ViewModel.GiangVienVM;
using DAMFINAL.DAL;
using DAMFINAL.DAL.Entities;
using DAMFINAL.DAL.Repositories.Implement;
using DAMFINAL.DAL.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMFINAL.BUS.Implement
{
    public class GiangVienService : IGiangVienService
    {   
        private readonly IGiangVienRepo _repo;
        private readonly AppDbContext _appDbContext;
        public GiangVienService()
        {
            _repo = new GiangVienRepo();
            _appDbContext = new AppDbContext();
        }
        public string Create(GiangVienCreateVM createVM)
        {
            Giangvien entity = GiangVienMapping.MapCreateVMToEntity(createVM);
            var result = _repo.Create(entity);
            return result;
        }

        public bool Delete(string code)
        {
            var result = _repo.Delete(code);
            return result;
        }

        public List<GiangVienVM> GetList()
        {
            List<Giangvien> entities = _repo.GetList();
            var vms = entities.Select(e => GiangVienMapping.MapEntityToVM(e)).ToList();
            return vms;
        }

        public bool Update(GiangVienUpdateVM updateVM)
        {
           Giangvien entity = GiangVienMapping.MapUpdateVMToEntity(updateVM);
            var result = _repo.Update(entity);
            return result;
        }
    }
}
