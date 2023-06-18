using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class ContractDocument:BaseEntity
    {
        //SozlesmeBilgileri
        public DateTime InceptionDate { get; set; }
        public DateTime TerminationDate { get; set; }
        public bool IsOverSeas { get; set; }
        public ContractType ContractType { get; set; }
        public ContractStatus ContractStatus { get; set; }
        public int? SaleID { get; set; }

        //Relational properties
        public virtual List<BiddingDocument> BiddingDocuments { get; set; }
        public virtual Sale Sale { get; set; }
    }
}
