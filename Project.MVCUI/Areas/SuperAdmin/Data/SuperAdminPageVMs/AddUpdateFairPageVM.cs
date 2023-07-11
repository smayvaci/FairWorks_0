using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPureVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs
{
    public class AddUpdateFairPageVM
    {
        public SuperFairPureVM Fair { get; set; }
        
        public List<SuperHallPureVM> Halls { get; set; }
        public List<SuperStandAreaPureVM> StandAreas { get; set; }
       
       
    }
}