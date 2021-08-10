using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos
{
    public class UsersWtihLocation
    {
        public int UserId { get; set; }
        public string BranchName { get; set; }
        public string DepartmentName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
