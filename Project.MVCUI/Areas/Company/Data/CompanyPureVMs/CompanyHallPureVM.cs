using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MVCUI.Areas.Company.Data.CompanyPureVMs
{
    public class CompanyHallPureVM
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DataStatus { get; set; }
        public string HallNumber { get; set; }
        public int? FairID { get; set; }
    }
}
