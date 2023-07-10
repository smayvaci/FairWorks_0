using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MVCUI.Areas.Company.Data.CompanyPureVMs
{
    public class CompanyApproachDocumentPureVM
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DataStatus { get; set; }
        public DateTime ApproachDate { get; set; }// görüşme tarihi 
        public string ApproachNotes { get; set; }// görüşme notları
        public int? CompanyID { get; set; }
        public string CompanyName { get; set;}
        public int? EmployeeID { get; set; }
        public string EmployeeName { get; set;}
        public int? FairID { get; set; }
        




    }
}
