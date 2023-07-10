using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SalesEmployee.Data.SalesEmployeePureVMs
{
    public class SaleSectorPureVM
    {
        
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DataStatus { get; set; }
        public string SectorName { get; set; }
        public int? CompanyID { get; set; }

    }
}