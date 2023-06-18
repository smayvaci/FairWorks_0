using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class InvitedGuestAndCompany:BaseEntity
    {   //JunctionTable
        public int InvitedGuestID { get; set; }
        public int CompanyID { get; set; }

        //Relational Properties
        public virtual InvitedGuest InvitedGuest{ get; set; }
        public virtual Company Company { get; set; }
    }
}
