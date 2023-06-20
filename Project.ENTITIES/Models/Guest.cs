using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{// 1 fuar n misafir
 // 1 misafir n fuar
    public class Guest:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string CompanyName { get; set; }
        public int? JobID { get; set; }


        //relational Properties
        public virtual List<FairAndGuest> FairAndGuests { get; set; }
        public virtual Job Job { get; set; }
    }
}
