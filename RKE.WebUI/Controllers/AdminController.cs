using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace RKE.WebUI.Controllers
{
    public class AdminController : Controller
    {
        
        [Authorize]
        public ActionResult Index()
        {

            return View();
        }
        public void CheckIfLessonExist(int idOfPrevLesson,int day,int numberOfLesson, int week )
        {
            
        }

    }
}