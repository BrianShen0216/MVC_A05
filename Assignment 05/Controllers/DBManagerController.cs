using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL.Models;

namespace Assignment_05.Controllers
{
    public class DBManagerController : Controller
    {
        UserDBEntities db = new UserDBEntities();
        // GET: DBManager
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Display()
        {
            return View(db.Users.ToList());
        }
    }
}