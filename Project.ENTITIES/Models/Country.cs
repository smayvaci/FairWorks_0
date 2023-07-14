using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Country:BaseEntity
    {// 1 ülke n firma
     // 1 firma  1 ülke
        public string CountryName { get; set; }
       

        //Relational Properties
        public virtual List<Company> Companies { get; set; }

    }
}
