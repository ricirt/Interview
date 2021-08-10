using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Department:IEntity
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public User Users { get; set; }
        public ICollection<Branch> Branches { get; set; }
    }
}
