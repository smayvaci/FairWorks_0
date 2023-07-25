using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminRequestModels.AddRequestModels;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminResponseModels.SuperAdminPureVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs.AddPageVMs
{
    public class AddStandAreaPageVM
    {
        public AddStandAreaPageVM StandArea { get; set; }
        public List<SuperHallPureVM> Halls { get; set; }
        public List<SuperFairPureVM> Fairs { get; set; }
    }
}