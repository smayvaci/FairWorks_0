﻿using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPureVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs
{
    public class ListPaymentSchedulePageVM
    {
        public List<SuperCompanyPureVM> MyProperty { get; set; }
        public List<SuperSalesPureVM> Sales { get; set; }
        public List<SuperCompanyPureVM> Companies { get; set; }
        public List<SuperContractDocumentPureVM> ContractDocuments { get; set; }
        public List<SuperExchangeTypePureVM> ExchangeTypes { get; set; }
    }
}