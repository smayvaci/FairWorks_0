using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Fair:BaseEntity
    {
        public string FairName { get; set; }
        public string EntranceDoor { get; set; }
        public string ExitDoor { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpiryDate{ get; set; }
        public string Location { get; set; }

        //Relataional Properties
        public virtual List<FairAndHall>FairAndHalls { get; set; }
        public virtual List<FairAndGuest> FairAndGuests { get; set; }
        public virtual List<FairAndApproachDocument> FairAndApproachDocuments { get; set; }

        //ToDo Fuar Sektörü belirlemek için Sector Classı mı ??

    }
}
