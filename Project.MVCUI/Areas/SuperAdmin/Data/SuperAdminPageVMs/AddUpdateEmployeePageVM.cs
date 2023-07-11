using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPureVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs
{
    public class AddUpdateEmployeePageVM
    {
        public SuperEmployeePureVM Employee { get; set; }
        public List<SuperEmployeeRolePureVM> EmployeeRoles { get; set; }
    
    }
}