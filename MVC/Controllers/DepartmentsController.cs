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

        [HttpPost]
        public IActionResult AddDepartment(Department department)
        {
            _locationService.Add(department);
            return View();
        }
        [HttpPost]
        public IActionResult UpdateDepartment(Department department)
        {
            _locationService.Update(department);
            return View();
        }
        [HttpPost]
        public IActionResult DeleteDepartment(Department department)
        {
            _locationService.Delete(department);
            return View();
        }
        public IActionResult GetDepartments()
        {
            var departments =_locationService.GetAll();
            return View(departments);
        }
    }
}
