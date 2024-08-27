using DAMFINAL.BUS.Interface;
using DAMFINAL.BUS.Utils.Mapping;
using DAMFINAL.BUS.ViewModel.BuoiTroGiangVM;
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
    public class BuoiTroGiangService : IBuoiTroGiangService
    {
        private readonly IBuoiTroGiangRepo _repo;
        private readonly AppDbContext _appDbContext;

        public BuoiTroGiangService()
        {
            _repo = new BuoiTroGiangRepo();
            _appDbContext = new AppDbContext();
        }

        public string Create(BuoiTroGiangCreateVM createVM)
        {
            string generatedMaBTG = GenerateMaBuoiTroGiang();
            Buoitrogiang entity = BuoiTroGiangMapping.MapCreateVMToEntity(createVM, generatedMaBTG);
            var result = _repo.Create(entity);
            return result;
        }

        public bool Delete(string code)
        {
            var result = _repo.Delete(code);
            return result;
        }

        public List<BuoiTroGiangVM> GetList()
        {
            List<Buoitrogiang> entities = _repo.GetList();
            var vms = entities.Select(e => BuoiTroGiangMapping.MapEntityToVM(e)).ToList();
            return vms;
        }

        public bool Update(BuoiTroGiangUpdateVM updateVM)
        {
            Buoitrogiang entity = BuoiTroGiangMapping.MapUpdateVMToEntity(updateVM);
            var result = _repo.Update(entity);
            return result;
        }

        private string GenerateMaBuoiTroGiang()
        {
            var list = _repo.GetList();
            var lastMaBTG = list
                .Select(btg => btg.Mabtg)
                .OrderByDescending(ma => ma)
                .FirstOrDefault();
            if (string.IsNullOrEmpty(lastMaBTG))
            {
                return "BTG001";
            }
            int lastNumber = int.Parse(lastMaBTG.Substring(3));
            int newNumber = lastNumber + 1;
            string newMaBTG = "BTG" + newNumber.ToString("D3");
            return newMaBTG;
        }
    }
}
