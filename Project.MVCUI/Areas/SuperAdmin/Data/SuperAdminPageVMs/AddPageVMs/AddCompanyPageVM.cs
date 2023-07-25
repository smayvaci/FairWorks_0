using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminRequestModels.AddRequestModels;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminRequestModels.UpdateRequestModels;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminResponseModels.SuperAdminPureVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs.AddPageVMs
{
    public class AddCompanyPageVM
    {
        public AddCompanyRequestModel Company { get; set; }
        public List<SuperCompanyTypePureVM> CompanyTypes { get; set; }
        public List<SuperSectorPureVM> Sectors { get; set; }
        public List<SuperCountryPureVM> Countries { get; set; }
    }
}