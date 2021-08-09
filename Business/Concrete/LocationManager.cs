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

        public void Add(Location location)
        {
            _locationDal.Add(location);
        }

        public void Delete(Location location)
        {
            _locationDal.Delete(location);
        }

        public List<Location> GetAll()
        {
            return _locationDal.GetAll();
        }

        public Location GetById(int id)
        {
            return _locationDal.Get(l => l.Id == id);
        }

        public void Update(Location location)
        {
            _locationDal.Update(location);
        }
    }
}
