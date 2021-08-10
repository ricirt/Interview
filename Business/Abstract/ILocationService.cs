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
        List<Department> GetAll();
        void Add(Department location);
        void Update(Department location);
        void Delete(Department location);
        Department GetById(int id);
    }
}
