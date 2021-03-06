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
        [HttpGet]
        public IActionResult AddBranch()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddBranch(Branch branch)
        {
            if(ModelState.IsValid)
                _branchService.Add(branch);
            return View();
        }
        [HttpPost]
        public IActionResult UpdateBranch(Branch branch)
        {
            if (ModelState.IsValid)
                _branchService.Update(branch);
            return View();
        }
        [HttpPost]
        public IActionResult DeleteBranch(Branch branch)
        {
            _branchService.Delete(branch);
            return View();
        }
        public IActionResult BranchList()
        {
            var branches = _branchService.GetAll();
            return View(branches);
        }
    }
}
