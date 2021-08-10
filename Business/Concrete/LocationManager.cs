using Business.Abstract;
using DataAccess.Abstract;
using Entity;
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

        public LocationManager(ILocationDal locationDal)
        {
            _locationDal = locationDal;
        }

        public void Add(Department department)
        {
            _locationDal.Add(department);
        }

        public void Delete(Department department)
        {
            _locationDal.Delete(department);
        }

        public List<Department> GetAll()
        {
            return _locationDal.GetAll();
        }

        public Department GetById(int id)
        {
            return _locationDal.Get(l => l.DepartmentId == id);
        }

        public void Update(Department department)
        {
            _locationDal.Update(department);
        }
    }
}
