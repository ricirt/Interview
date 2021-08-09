using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Location:IEntity
    {
        public int Id { get; set; }
        public string Branch { get; set; }
        public string Department { get; set; }
        public User Users { get; set; }
    }
}
