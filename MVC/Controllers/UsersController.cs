using Business.Abstract;
using Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class UsersController : Controller
    {
        IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult UserList()
        {

           var users = _userService.GetUsersWtihLocations();
            return View(users);
        }
        public IActionResult AddUser()
        {
            ViewBag.Branches = _userService.GetBranches();
            return View();
        }
        [HttpPost]
        public IActionResult AddUser(User user)
        {
            ViewBag.Branches = _userService.GetBranches();
            if (ModelState.IsValid)
                _userService.Add(user);
            return View();
        }
        [HttpPost]
        public IActionResult UpdateUser(User user)
        {
            if (ModelState.IsValid)
                _userService.Update(user);
            return View();
        }
        [HttpPost]
        public IActionResult DeleteUser(User user)
        {
            _userService.Delete(user);
            return View();
        }
    }
}
