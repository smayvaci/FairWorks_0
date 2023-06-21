using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPureVMs
{
    public class SuperEmployeePureVMs
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string TrID { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? CountryID { get; set; }
        public string CountryName { get; set; }
        public int? EmplyoeeRoleID { get; set; }
        public string TitleName { get; set; }
        public int? JobID { get; set; }
        public string JobName { get; set; }
    }
}