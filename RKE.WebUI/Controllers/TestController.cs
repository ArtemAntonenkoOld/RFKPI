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
        public async Task Index()
        {
            await _logic.SetTeachers();
        }
        public async Task SetGroups()
        {
            await _logic.SetGroups();
        }
    }

    }
