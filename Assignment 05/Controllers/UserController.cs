using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using Assignment_05.Models;
using DAL.Models;
using BLL;
using System.Runtime.CompilerServices;

namespace Assignment03.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Register()
        {
            TempUser tmp_u = new TempUser();
            tmp_u.Name = Request.Form["UserName"];
            tmp_u.Email = Request.Form["email"];
            tmp_u.Password = Request.Form["Password"];
            return View(tmp_u);
        }

        [HttpPost]
        public ActionResult Register(TempUser tmp_u)
        {
            if (ModelState.IsValid)
            {
                Users user = new Users();
                user.Name = tmp_u.Name;
                user.Email = tmp_u.Email;
                user.Password = tmp_u.Password;
                int res = new BLLClass().AddUser_BLL(user);
                return View("Confirmation",user);
            }
            return View();
        }

        [HttpPost]
        public ActionResult Confirmation(Users user)
        {
            return View();
        }
    }
}