using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MVCUI.Areas.Company.Data.CompanyPureVMs
{
    public class CompanySalePureVM
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DataStatus { get; set; }
        public decimal SubTotal { get; set; }
        public DateTime SaleDate { get; set; }
        public int? ContractDocumentID { get; set; }
        public string MyProperty { get; set; }
    }
}
