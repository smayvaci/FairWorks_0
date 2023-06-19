using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class FairAndApproachDocument:BaseEntity
    {// 1 fuar n görüşme
     // 1 görüşme n fuar
        public int FairID { get; set; }
        public int ApproachDocumentID { get; set; }

        //Relational Properties
        public virtual Fair Fair { get; set; }
        public virtual ApproachDocument ApproachDocument { get; set; }
    }
}
