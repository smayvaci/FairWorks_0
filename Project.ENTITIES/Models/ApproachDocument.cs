using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class ApproachDocument:BaseEntity
    {
        //GörüsmeBigileri
        public DateTime ApproachDate { get; set; } 
        public string ApproachNotes  { get; set; }
        public int? EmployeeID { get; set; }

        //Relational Properties
        public virtual  Employee Employee { get; set; }
        public virtual List<BiddingDocument>BiddingDocuments { get; set; }
    }
}
