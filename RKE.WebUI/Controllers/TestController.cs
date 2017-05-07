using RKE.API.BL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace RKE.WebUI.Controllers
{
    public class TestController : Controller
    {    private readonly IRozkladUpdateHandler _logic;
        public TestController(IRozkladUpdateHandler logic)
        {
            _logic = logic;
        }
        public async Task SetTeachers()
        {
           await  _logic.SetTeachers();
        }
        public async Task SetGroups()
        {
            await _logic.SetGroups();
        }
        
        public async Task SetLessons()
        {
            await _logic.SetLessons();
        }
        public async Task SetAuds()
        {
             await _logic.SetAuds();
        }
        public async Task SetDisziplins()
        {
             await _logic.SetDisziplins();
        }
        public async Task SetAll()
        {
            await _logic.SetAuds();
            await _logic.SetDisziplins();
            await _logic.SetGroups();
            await _logic.SetTeachers();
            await _logic.SetLessons();
        }
    }

    }
