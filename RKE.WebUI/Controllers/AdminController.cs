using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RKE.WebUI.Controllers
{
    public class AdminController : Controller
    {
        
        [Authorize(Roles = "Teacher")]
        public ActionResult Index()
        {
            return View();
        }
    }
}