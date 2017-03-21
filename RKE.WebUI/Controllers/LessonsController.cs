using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using Castle.Core.Internal;
using Castle.MicroKernel.ModelBuilder.Descriptors;

namespace RKE.WebUI.Controllers
{
    public class LessonsController : Controller
    {
        public ActionResult Index(string text)
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
                    return View("LessonsForStudents");

                }
            }
            else
            {
                return View("Index");
            }
        }

        
    }
}