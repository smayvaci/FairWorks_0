using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPureVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs
{
    public class ListGuestPageVM
    {
        public List<SuperGuestPureVM>  Guest { get; set; }
        public List<SuperJobPureVM> Jobs { get; set; }
    }
}