using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using RKE.BL.Abstract;
using RKE.UIModels.RozkladModel;

namespace RKE.WebUI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private readonly IRozkladDataHandler _logic;
        public HomeController(IRozkladDataHandler logic)
        {
            _logic = logic;
        }
        public async Task<ActionResult> Test(string groupname)
        {
            RozkladModel re = await _logic.GetByGroup(groupname);
            return View(re);
        }
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/Details/5
    }
}
