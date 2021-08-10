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
    public class EfUserDal:EfEntityRepositoryBase<User, LocationContext>,IUserDal
    {
        public List<UsersWtihLocation> GetUsersWtihLocations()
        {
            using (LocationContext context=new LocationContext())
            {
                var users = from u in context.Users
                            join b in context.Branches
                            on u.BranchId equals b.BranchId
                            select new UsersWtihLocation
                            {
                                Email = u.Email,
                                BranchName = b.BranchName,
                                Name = u.Name,
                                Phone = u.Phone,
                                Surname = u.Surname,
                                UserId = u.UserId

                            };
                return users.ToList();
            }
            
        }
    }
}
