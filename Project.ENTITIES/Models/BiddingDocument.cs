using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class BiddingDocument:BaseEntity
    {
        //TeklifBilgileri
        public DateTime BiddingDate { get; set; }
        public DateTime BiddingDeadLine { get; set; }
        public int? ApproachDocumentID { get; set; }
        public int? ContractDocumentID { get; set; }

        //Relational Properties
        public virtual ApproachDocument ApproachDocument { get; set; }
        public virtual ContractDocument ContractDocument { get; set; }
    }
}
