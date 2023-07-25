using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminRequestModels;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminRequestModels.UpdateRequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs.UpdatePageVMs
{
    public class UpdateStandAreaPageVM
    {
        public List<UpdateFairRequestModel> Fairs { get; set; }
        public List<UpdateHallRequestModel> Halls { get; set; }
        public UpdateStandAreaRequestModel StandArea { get; set; }
    }
}