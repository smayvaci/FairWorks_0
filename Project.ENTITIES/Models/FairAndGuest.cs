using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class FairAndGuest:BaseEntity
    {// junction Table
        public int FairID { get; set; }
        public int GuestID { get; set; }

        //relational properties
        public virtual Fair Fair { get; set; }
        public virtual Guest Guest { get; set; }
    }
}
