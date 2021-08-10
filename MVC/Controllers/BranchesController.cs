using Business.Abstract;
using Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class BranchesController : Controller
    {
        IBranchService _branchService;

        public BranchesController(IBranchService branchService)
        {
            _branchService = branchService;
        }

        [HttpPost]
        public IActionResult AddDepartment(Branch branch)
        {
            _branchService.Add(branch);
            return View();
        }
        [HttpPost]
        public IActionResult UpdateDepartment(Branch branch)
        {
            _branchService.Update(branch);
            return View();
        }
        [HttpPost]
        public IActionResult DeleteDepartment(Branch branch)
        {
            _branchService.Delete(branch);
            return View();
        }
        public IActionResult GetDepartments()
        {
            var branches = _branchService.GetAll();
            return View(branches);
        }
    }
}
