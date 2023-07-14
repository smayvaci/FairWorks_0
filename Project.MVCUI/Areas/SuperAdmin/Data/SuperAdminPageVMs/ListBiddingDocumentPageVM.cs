﻿using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPureVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs
{
    public class ListBiddingDocumentPageVM
    {
        public List<SuperBiddingDocumentPureVM> BiddingDocuments { get; set; }
        public List<SuperCompanyPureVM> Companies { get; set; }
        public List<SuperEmployeePureVM> Employees { get; set; }
    }
}