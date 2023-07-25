using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminRequestModels.AddRequestModels;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminRequestModels.UpdateRequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs.AddPageVMs
{
    public class AddCompanyPageVM
    {
        public AddCompanyRequestModel Company { get; set; }
        public List<AddCompanyTypeRequestModel> CompanyTypes { get; set; }
        public List<AddSectorRequestModel> Sectors { get; set; }
        public List<AddCountryRequestModel> Countries { get; set; }
    }
}