using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPureVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs
{
    public class AddUpdateCompanyPageVM
    {
        public SuperCompanyPureVM Company { get; set; }
        public List<SuperCompanyTypePureVM> CompanyTypes { get; set; }
        public List<SuperCountryPureVM> Countries { get; set; }
        public List<SuperSectorPureVM> Sectors { get; set; }


    }
}