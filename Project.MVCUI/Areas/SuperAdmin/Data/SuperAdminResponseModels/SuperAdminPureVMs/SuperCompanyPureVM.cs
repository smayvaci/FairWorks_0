using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminResponseModels.SuperAdminPureVMs
{
    public class SuperCompanyPureVM
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DataStatus { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public string EMail { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? CompanyTypeID { get; set; }
        public string CompanyTypeName { get; set; }
        public int? CountryID { get; set; }
        public string CountryName { get; set; }
        public int? SectorID { get; set; }
        public string SectorName { get; set; }
    }
}