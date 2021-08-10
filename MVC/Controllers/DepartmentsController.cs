using Business.Abstract;
using Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class DepartmentsController : Controller
    {

        ILocationService _locationService;

        public DepartmentsController(ILocationService locationService)
        {
            _locationService = locationService;
        }
        public IActionResult AddDepartment()
        {
            ViewBag.Branches = _locationService.GetBranches();
            return View();
        }
        [HttpPost]
        public IActionResult AddDepartment(Department department)
        {
            if (ModelState.IsValid)
                _locationService.Add(department);
            ViewBag.Branches = _locationService.GetBranches();
            return View();
        }
        [HttpPost]
        public IActionResult UpdateDepartment(Department department)
        {
            if (ModelState.IsValid)
                _locationService.Update(department);
            return View();
        }
        [HttpPost]
        public IActionResult DeleteDepartment(Department department)
        {
            _locationService.Delete(department);
            return View();
        }
        public IActionResult DepartmentList()
        {
            
            var departments =_locationService.GetDepartmentDetails();
            return View(departments);
        }
    }
}
