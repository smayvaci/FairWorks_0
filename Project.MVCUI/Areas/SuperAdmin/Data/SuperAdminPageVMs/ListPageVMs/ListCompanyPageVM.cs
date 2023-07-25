using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminResponseModels.SuperAdminPureVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs.ListPageVMs
{
    public class ListCompanyPageVM
    {
        public List<SuperCompanyPureVM>  Companies { get; set; }
        public List<SuperCompanyTypePureVM> CompanyTypes { get; set; }
        public List<SuperCountryPureVM> Countries { get; set; }
        public List<SuperSectorPureVM> Sectors { get; set; }
    }
}