using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBranchService
    {
        List<Branch> GetAll();
        void Add(Branch branch);
        void Update(Branch branch);
        void Delete(Branch branch);
        Branch GetById(int id);
    }
}
