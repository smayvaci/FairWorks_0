using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminResponseModels.SuperAdminPureVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs.ListPageVMs
{
    public class ListFairPageVM
    {
        public List<SuperFairPureVM> Fairs{ get; set; }
        public List<SuperHallPureVM> Halls { get; set; }
        public List<SuperStandAreaPureVM> StandAreas { get; set; }
    }
}