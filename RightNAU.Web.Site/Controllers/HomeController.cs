using System.Threading.Tasks;
using System.Web.Mvc;
using RKE.BL.Abstract;

namespace RKE.Web.Site.Controllers
{
    public class HomeController : Controller
    {
       
        private readonly IRozkladDataHandler _logic;
        public HomeController(IRozkladDataHandler logic)
        {
            _logic = logic;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Rozklad()
        {
            return View();
        }
        public ActionResult Map()
        {
            return View();
        }
        public ActionResult WeekRozklad()
        {
            return View();
        }


        

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}