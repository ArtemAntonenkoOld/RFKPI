using System.Web.Mvc;

namespace RKE.Web.Site.Controllers
{
    public class TestController : Controller
    {
        //private readonly IRozkladDataHandler _logic;
        /*public TestController(IRozkladDataHandler logic)
        {
            _logic = logic;
        }*/

        public /*async Task<string>*/ string Test()
        {
           // List<string> res = (await _logic.GetByGroup("ФМЛ 102")).Subjects1.Select(p => p.Name).ToList();
            string s = "fs";
           // res.ForEach(p => s += p);
            return s;
        }
    }
}