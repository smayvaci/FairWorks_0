using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminRequestModels;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminRequestModels.UpdateRequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs.UpdatePageVMs
{
    public class UpdateCompanyPageVM
    {
        public UpdateCompanyRequestModel  Company { get; set; }
        public List<UpdateCompanyTypeRequestModel> CompanyTypes { get; set; }
        public List<UpdateSectorRequestModel> Sectors { get; set; }
        public List<UpdateCountryRequestModel> Countries { get; set; }
    }
}