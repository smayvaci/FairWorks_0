using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminResponseModels.SuperAdminPureVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs.ListPageVMs
{
    public class ListEmployeeRolePageVM
    {
        public List<SuperEmployeeRolePureVM> EmployeeRoles { get; set; }
        public List<SuperEmployeePureVM> Employees { get; set; }
    }
}