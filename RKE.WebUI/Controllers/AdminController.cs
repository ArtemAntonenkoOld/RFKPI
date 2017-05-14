using RKE.BL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using RKE.UIModels.CRUDLessonForExternalModels;

namespace RKE.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private readonly ICRUDDataHandler _logic;
        public AdminController(ICRUDDataHandler logic)
        {
            _logic = logic;
        }
        [Authorize]
        public ActionResult Index()
        {

            return View();
        }
        public async Task<int> CheckIfLessonExist(int[] groups,DateTime date, int auds, int teachers, int disziplins)
        {
           return await _logic.SetLesson(groups,auds,teachers,disziplins,date);
        }
        public async Task<ActionResult> AddLesson()
        {
             CRUDLessonForExternalModelsDataModel re = await _logic.GetAllInfo();

            return View("AddExternalLesson",re);
        }
       

    }
}