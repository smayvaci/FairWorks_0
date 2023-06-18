using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class InvitedGuest:BaseEntity

    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string InvitationCard { get; set; }

        //Relational Properties
        public virtual List<InvitedGuestAndCompany>InvitedGuestAndCompanies { get; set; }
    }
}
