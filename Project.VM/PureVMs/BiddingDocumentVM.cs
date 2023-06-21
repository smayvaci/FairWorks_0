using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.VM.PureVMs
{
    public class BiddingDocumentVM
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DataStatus { get; set; }
        public DateTime BiddingInceptionDate { get; set; }// teklif başlangıç günü
        public DateTime BidingTerminationDate { get; set; }// teklif geçerlilik son günü
        public int? ApproachDocumentID { get; set; }
        
    }
}
