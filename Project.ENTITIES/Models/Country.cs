using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Country:BaseEntity
    {
        public string CountryName { get; set; }
        public string Region { get; set; }
        public string Language { get; set; }
        public string PhoneCode { get; set; }
        public string Description { get; set; }

        //Relational Properties
        public virtual List<CountryAndCompany> CountryAndCompanies { get; set; }
    }
}
