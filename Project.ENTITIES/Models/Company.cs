using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Company : BaseEntity
    {
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public string EMail { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? CountryID { get; set; }

        //Relational Properties 

        public virtual List<CompanyAndCompanyType>CompanyAndCompanyTypes { get; set; }
        public virtual Country Country { get; set; }
        public virtual List<InvitedGuestAndCompany>InvitedGuestAndCompanies { get; set; }
        public virtual List<SectorAndCompany>SectorAndCompanies { get; set; }
        public virtual List<ApproachDocument> ApproachDocuments { get; set; }


    }


    

}
    
