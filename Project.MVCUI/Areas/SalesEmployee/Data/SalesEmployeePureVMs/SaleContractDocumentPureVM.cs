﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SalesEmployee.Data.SalesEmployeePureVMs
{
    public class SaleContractDocumentPureVM
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DataStatus { get; set; }
        public DateTime InceptionDate { get; set; }
        public DateTime TerminationDate { get; set; }
        public bool IsOverSeas { get; set; }// yurt dışından mı
        public string ContractStatus { get; set; }// yapıldı mı yapılmadı mı
        public string ContractType { get; set; }
        public int? BiddingDocumentID { get; set; }
        public int? CompanyID { get; set; }
        public string CompanyName { get; set; }
        public int? EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int? StandAreaID { get; set; }
    }
}