using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPureVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs
{
    public class AddUpdateHallVM
    {
        public SuperHallPureVM Hall { get; set; }
        public List<SuperStandAreaPureVM> StandAreas { get; set; }
        


    }
}