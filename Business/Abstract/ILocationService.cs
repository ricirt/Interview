using Entity;
using Entity.Dtos;
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
        void Add(Department department);
        void Update(Department department);
        void Delete(Department department);
        Department GetById(int id);
        public List<DepartmentDetails> GetDepartmentDetails();
        public List<Branch> GetBranches();
    }
}
