using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eproject.Models;
namespace eproject.Controllers
{
    public class SignupController : Controller
    {
        // GET: Signup
        [HttpGet]
        public ActionResult AddOrEdit(int id = 0)

        {
            singuptable singupmodel = new singuptable();
            return View(singupmodel);
        }
        [HttpPost]
        public ActionResult AddOrEdit(singuptable singupmodel)
        {
            using (EprojectdatabaseEntities1 dbmodel = new EprojectdatabaseEntities1())
            {
                dbmodel.singuptables.Add(singupmodel);
                dbmodel.SaveChanges();
                

            }
            ModelState.Clear();

            return View("AddOrEdit", new singuptable());
        }

    }
}