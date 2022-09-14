using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eproject.Models;

namespace eproject.Controllers
{
    public class HomeController : Controller
    {
        EprojectdatabaseEntities1 db = new EprojectdatabaseEntities1();
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.main ="Index";
            return View();
        }

        public ActionResult Single()
        {
            return View();
        }

        public ActionResult payment()
        {
            return View();
        }

        public ActionResult Orders()
        {
            return View();
        }

        public ActionResult Setting()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(string name, string mobile_number, string email_id, string password)
        {
            signup s = new signup();
            s.name = name;
            s.mobile_number = mobile_number;
            s.email_id = email_id;
            s.password = password;
            db.signups.Add(s);
            db.SaveChanges();
            return RedirectToAction("Index", "SignUpMsg");
        }
    }
}