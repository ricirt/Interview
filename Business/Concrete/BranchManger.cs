using Business.Abstract;
using DataAccess.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BranchManger : IBranchService
    {
        IBranchDal _branchDal;

        public BranchManger(IBranchDal branchDal)
        {
            _branchDal = branchDal;
        }

        public void Add(Branch branch)
        {
            _branchDal.Add(branch);
        }

        public void Delete(Branch branch)
        {
            _branchDal.Delete(branch);
        }

        public List<Branch> GetAll()
        {
            return _branchDal.GetAll();
        }

        public Branch GetById(int id)
        {
            return _branchDal.Get(b => b.BranchId == id);

        }

        public void Update(Branch branch)
        {
            _branchDal.Update(branch);
        }
    }
}
