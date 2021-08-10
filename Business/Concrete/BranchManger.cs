using Business.Abstract;
using Business.Caching;
using DataAccess.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BranchManger : IBranchService
    {
        IBranchDal _branchDal;
        ICacheService _cacheService;

        public BranchManger(IBranchDal branchDal,ICacheService cacheService)
        {
            _branchDal = branchDal;
            _cacheService = cacheService;
        }

        public void Add(Branch branch)
        {
            _branchDal.Add(branch);
            _cacheService.Remove("Branches.GetAll");
        }

        public void Delete(Branch branch)
        {
            _branchDal.Delete(branch);
            _cacheService.Remove("Branches.GetAll");
        }

        public List<Branch> GetAll()
        {
            if (_cacheService.Any("Branches.GetAll"))
            {
                var departments = _cacheService.Get<List<Branch>>("Branches.GetAll");
                return departments;
            }
            var departmentsCached = _branchDal.GetAll();
            _cacheService.Add("Branches.GetAll", departmentsCached);
            return departmentsCached;
        }

        public Branch GetById(int id)
        {
            return _branchDal.Get(b => b.BranchId == id);

        }

        public void Update(Branch branch)
        {
            _branchDal.Update(branch);
            _cacheService.Remove("Branches.GetAll");
        }
    }
}
