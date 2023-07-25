using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminRequestModels;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminResponseModels.SuperAdminPureVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs.UpdatePageVMs
{
    public class UpdateHallPageVM
    {
        public UpdateHallPageVM Hall { get; set; }
        public List<SuperFairPureVM> Fairs  { get; set; }
    }
}