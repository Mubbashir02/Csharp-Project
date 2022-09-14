using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eproject.Controllers
{
    public class SignUpMsgController : Controller
    {
        // GET: SignUpMsg
        public ActionResult Index()
        {
            ViewBag.msg = "Account created successfully";
            return View();
        }
    }
}