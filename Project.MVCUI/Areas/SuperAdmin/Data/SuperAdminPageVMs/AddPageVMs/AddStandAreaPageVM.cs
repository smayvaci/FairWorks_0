using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminRequestModels.AddRequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs.AddPageVMs
{
    public class AddStandAreaPageVM
    {
        public AddStandAreaPageVM StandArea { get; set; }
        public List<AddHallRequestModel> Halls { get; set; }
        public List<AddFairRequestModel> Fairs { get; set; }
    }
}