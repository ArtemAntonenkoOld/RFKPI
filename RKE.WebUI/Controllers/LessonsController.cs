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
using RKE.UIModels.RozkladModelsForTeachers;
using StringExtensions = Bender.Extensions.StringExtensions;

namespace RKE.WebUI.Controllers
{
    public class LessonsController : Controller
    {
        private readonly IRozkladHandler _logic;
        public LessonsController(IRozkladHandler logic)
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
                    RozkladModelForTeachersTeacherModel re = await _logic.GetByNameOfTeacher(text);
                    if (StringExtensions.IsNullOrEmpty(re))
                    {
                        return View("Index");
                    }
                    else
                    {
                        return View("LessonsForTeachers",re);
                    }
                }
                else
                {
                    RozkladModelForStudentsRozkladModel re = await _logic.GetByGroup(text);
                    if (StringExtensions.IsNullOrEmpty(re))
                    {
                        return View("Index");
                    }
                    else
                    {
                        return View("LessonsForStudents", re);
                    }
                }
            }
            else
            {
                return View("Index");
            }
        }

        
    }
}