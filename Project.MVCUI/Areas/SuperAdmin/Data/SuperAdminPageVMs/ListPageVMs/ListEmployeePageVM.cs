using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminResponseModels.SuperAdminPureVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs.ListPageVMs
{
    public class ListEmployeePageVM
    {
        public List<SuperEmployeePureVM> Employees { get; set; }
        public List<SuperEmployeePureVM> EmployeeRoles { get; set; }
    }
}