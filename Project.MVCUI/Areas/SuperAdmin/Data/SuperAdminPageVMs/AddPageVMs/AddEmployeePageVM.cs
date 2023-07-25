using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminRequestModels.AddRequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs.AddPageVMs
{
    public class AddEmployeePageVM
    {
        public AddEmployeeRequestModel  Employee { get; set; }
        public List<AddEmployeeRoleRequestModel> EmployeeRoles { get; set; }
    }
}