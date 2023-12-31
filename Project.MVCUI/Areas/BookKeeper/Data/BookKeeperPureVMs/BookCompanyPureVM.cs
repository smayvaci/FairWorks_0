﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.BookKeeper.Data.BookKeeperPureVMs

{
    public class BookCompanyPureVM
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
    }
}