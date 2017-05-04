using RKE.BL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace RKE.WebUI.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly IRestDataHandler _logic;
        public ValuesController(IRestDataHandler logic)
        {
            _logic = logic;
        }

        public async Task Index()
        {
            await _logic.GetAllGroups();
        }
    }
}
