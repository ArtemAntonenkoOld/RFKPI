using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RKE.WebUI.Controllers
{
    public class TestController : Controller
    {
        public /*async Task<string>*/ string Test()
        {
            // List<string> res = (await _logic.GetByGroup("ФМЛ 102")).Subjects1.Select(p => p.Name).ToList();
            string s = "fs";
            // res.ForEach(p => s += p);
            return s;
        }

    }
}