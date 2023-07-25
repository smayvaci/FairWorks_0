using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminRequestModels.UpdateRequestModels
{
    public class UpdateEmployeeRoleRequestModel
    {
        public int ID { get; set; }
        public string TitleName { get; set; }
        public string Department { get; set; }
        public string Description { get; set; }
    }
}