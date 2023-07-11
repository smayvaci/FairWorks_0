using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPureVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs
{
    public class AddUpdateSalePageVM
    {
        public SuperSalePureVM Sale { get; set; }
        public List<SuperContractDocumentPureVM> ContractDocuments { get; set; }
        public List<SuperEmployeePureVM> Employees { get; set; }
        public List<SuperExchangeTypePureVM> ExchangeTypes { get; set; }
        public List<SuperCompanyPureVM> Companies { get; set; }
        public List<SuperBiddingDocumentPureVM> BiddingDocuments { get; set; }
        public List<SuperFairPureVM> Fairs { get; set; }
        public List<SuperPaymentSchedulePureVM> PaymentSchedules { get; set; }
        public List<SuperHallPureVM> Halls { get; set; }
        public List<SuperStandAreaPureVM> StandArea { get; set; }
        public List<SuperAdditionalServicePureVM> AdditionalServices { get; set; }

    }
}