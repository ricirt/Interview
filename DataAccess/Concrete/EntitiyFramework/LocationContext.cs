using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class LocationContext:DbContext
    {


        public DbSet<User> Users{ get; set; }
        public DbSet<Department>Locations{ get; set; }
        public DbSet<Branch> Branches { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-PT432LC\LOCAL;Initial Catalog=GayeBilisim;Trusted_Connection=True;");
        }

    }



}
