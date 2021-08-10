using Entity;
using Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ILocationDal: IEntityRepositoryBase<Department>
    {
        List<DepartmentDetails> GetDepartmentDetails();
    }
}
