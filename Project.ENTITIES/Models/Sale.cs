using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Sale:BaseEntity
    {
       
        public decimal SalePrice { get; set; }
        public DateTime SaleDate { get; set; }
        public int? PaymentScheduleID { get; set; }
        public int? AdditionalServiceID { get; set; }

        //Relational Properties
        public virtual List<ContractDocument>ContractDocuments { get; set; }
        public virtual PaymentSchedule PaymentSchedule { get; set; }
        public virtual AdditionalService AdditionalService { get; set; }


    }
}
