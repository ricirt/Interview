using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILocationService
    {
        List<Location> GetAll();
        void Add(Location location);
        void Update(Location location);
        void Delete(Location location);
        Location GetById(int id);
    }
}
