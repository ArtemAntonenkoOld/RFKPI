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
using RKE.UIModels.RozkladModelForStudents;
using RKE.ViewModels.RozkladModelsForTeachers;

namespace RKE.WebUI.Controllers
{
    public class LessonsController : Controller
    {
        private readonly IRozkladForStudentsHandler _logic;
        public LessonsController(IRozkladForStudentsHandler logic)
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
                    RozkladForTeachersModel re = await _logic.GetByNameOfTeacher(text);
                    return View("LessonsForTeachers");
                }
                else
                {
                    RozkladModel re = await _logic.GetByGroup(text);
                   
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