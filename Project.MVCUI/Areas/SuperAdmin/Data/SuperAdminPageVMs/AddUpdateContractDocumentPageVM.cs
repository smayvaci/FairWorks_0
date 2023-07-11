using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPureVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs
{
    public class AddUpdateContractDocumentPageVM

    {
        public SuperContractDocumentPureVM ContractDocument { get; set; }
        public List<SuperEmployeePureVM> Employess  { get; set; }
        public List<SuperSalesPureVM> Companies { get; set; }
        public List<SuperBiddingDocumentPureVM> BiddingDocuments { get; set; }
        public List<SuperFairPureVM> Fairs { get; set; }
        public List<SuperSalesPureVM> Sales { get; set; }
        public List<SuperAdditionalServicePureVM> AdditionalServices { get; set; }

    }
}