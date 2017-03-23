using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Castle.Core.Internal;
using Castle.MicroKernel.ModelBuilder.Descriptors;
using RKE.BL.Abstract;
using RKE.UIModels.RozkladModel;

namespace RKE.WebUI.Controllers
{
    public class LessonsController : Controller
    {
        private readonly IRozkladDataHandler _logic;
        public LessonsController(IRozkladDataHandler logic)
        {
            _logic = logic;
        }

        public async Task<ActionResult>  Index(string text)
        {
            if (!text.IsNullOrEmpty())
            {
                Regex regex = new Regex(@"\d");
                MatchCollection match = regex.Matches(text);
                if (text.EndsWith("з"))
                {
                    return View("LessonsForExternalStudents");

                }
                else if (match.IsNullOrEmpty())
                {
                    return View("LessonsForTeachers");
                }
                else
                {
                    List<RozkladModel> re = await _logic.GetByGroup(text);
                   
                    return View("LessonsForStudents", re);

                }
            }
            else
            {
                return View("Index");
            }
        }

        
    }
}