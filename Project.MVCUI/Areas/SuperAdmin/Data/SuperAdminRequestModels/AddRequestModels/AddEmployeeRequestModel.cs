using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminRequestModels.AddRequestModels
{
    public class AddEmployeeRequestModel
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string TrID { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? ReportTo { get; set; }
        public int? EmployeeRoleID { get; set; }
        public string TitleName { get; set; }

    }
}