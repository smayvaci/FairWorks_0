using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPureVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs
{
    public class ListInvitedGuestPageVM
    {
        public List<SuperInvitedGuestPureVM> InvitedGuests { get; set; }
        public List<SuperFairPureVM> Fairs { get; set; }
        public List<SuperSalePureVM> Sales { get; set; }
        public List<SuperEmployeePureVM> Employees { get; set; }
    }
}