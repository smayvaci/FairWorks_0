using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPureVMs
{
    public class SuperBiddingDocumentPureVM
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