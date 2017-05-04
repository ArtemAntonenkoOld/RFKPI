using RKE.API.Models.AllGroupsApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKE.API.BL.Abstract
{
    public interface IRozkladUpdateHandler
    {
        Task SetGroups();
        Task SetTeachers();
    }
}
