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

        public void Add(Department location)
        {
            _locationDal.Add(location);
        }

        public void Delete(Department location)
        {
            _locationDal.Delete(location);
        }

        public List<Department> GetAll()
        {
            return _locationDal.GetAll();
        }

        public Department GetById(int id)
        {
            return _locationDal.Get(l => l.DepartmentId == id);
        }

        public void Update(Department location)
        {
            _locationDal.Update(location);
        }
    }
}
