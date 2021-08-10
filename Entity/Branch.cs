using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Branch:IEntity
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public ICollection<Department> Departments{ get; set; }
        public ICollection<User> Users { get; set; }
    }
}
