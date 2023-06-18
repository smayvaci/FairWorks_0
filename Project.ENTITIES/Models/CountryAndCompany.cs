using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class CountryAndCompany:BaseEntity
    {
        public int CountryID { get; set; }
        public int CompanyID { get; set; }

        //Relational Properties
        public virtual Country Country { get; set; }
        public virtual Company Company{ get; set; }
    }
}
