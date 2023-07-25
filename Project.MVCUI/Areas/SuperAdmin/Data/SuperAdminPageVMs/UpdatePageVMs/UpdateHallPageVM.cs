using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminRequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs.UpdatePageVMs
{
    public class UpdateHallPageVM
    {
        public UpdateHallPageVM Hall { get; set; }
        public List<UpdateStandAreaPageVM>    StandAreas  { get; set; }
    }
}