using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity;
using Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfLocationDal : EfEntityRepositoryBase<Department, LocationContext>, ILocationDal
    {
        public List<DepartmentDetails> GetDepartmentDetails()
        {
            using (LocationContext context = new LocationContext())
            {
                var departments = from  d in context.Locations
                            join b in context.Branches
                            on d.BranchId equals b.BranchId
                            select new DepartmentDetails
                            {
                                BranchName=b.BranchName,
                                DepartmentName=d.DepartmentName,
                                DepartmentId=d.DepartmentId
                            };
                return departments.ToList();
            }
        }
    }
}
