using Business.Abstract;
using Business.Caching;
using DataAccess.Abstract;
using Entity;
using Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class LocationManager : ILocationService
    {
        ILocationDal _locationDal;
        IBranchService _branchService;
        ICacheService _cacheService;
        public LocationManager(ILocationDal locationDal, IBranchService branchService,ICacheService cacheService)
        {
            _locationDal = locationDal;
            _branchService = branchService;
            _cacheService = cacheService;
        }

        public void Add(Department department)
        {
            _locationDal.Add(department);
            _cacheService.Remove("Departments.GetAll");
        }

        public void Delete(Department department)
        {
            _locationDal.Delete(department);
            _cacheService.Remove("Departments.GetAll");
        }

        public List<Department> GetAll()
        {
            if (_cacheService.Any("Departments.GetAll"))
            {
                var departments = _cacheService.Get<List<Department>>("Departments.GetAll");
                return departments;
            }
            var departmentsCached = _locationDal.GetAll();
            _cacheService.Add("Departments.GetAll", departmentsCached);
            return departmentsCached;
        }

        public Department GetById(int id)
        {
            return _locationDal.Get(l => l.DepartmentId == id);
        }

        public void Update(Department department)
        {
            _locationDal.Update(department);
            _cacheService.Remove("Departments.GetAll");
        }
        public List<DepartmentDetails> GetDepartmentDetails()
        {
            if (_cacheService.Any("Departments.GetDepartmentDetails"))
            {
                var departments = _cacheService.Get<List<DepartmentDetails>>("Departments.GetDepartmentDetails");
                return departments;
            }
            var departmentsCached = _locationDal.GetDepartmentDetails();
            _cacheService.Add("Departments.GetDepartmentDetails", departmentsCached);
            return departmentsCached;
        }

        public List<Branch> GetBranches()
        {
            if (_cacheService.Any("Departments.GetBranches"))
            {
                var departments = _cacheService.Get<List<Branch>>("Departments.GetBranches");
                return departments;
            }
            var departmentsCached = _branchService.GetAll();
            _cacheService.Add("Departments.GetBranches", departmentsCached);
            return departmentsCached;
        }
    }
}
