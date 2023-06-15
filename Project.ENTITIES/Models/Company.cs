using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Company:BaseEntity
    {
        public string CompanyName { get; set; }
        public string CompanyOfficial { get; set; }
        public string Title { get; set; }
        public string PhoneNumber { get; set; }
        public string EMail { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Sector { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
