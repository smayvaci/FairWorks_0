using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class CompanyType:BaseEntity
    {// 1 tip n firma
     //  1 firma n tip   Tipten kastımız Üretici mi yoksa ithalatçı mı vs. gibi durumlar
        public string CompanyTypeName { get; set; }

        //Relational Properties

        public virtual List<CompanyAndCompanyType>CompanyAndCompanyTypes { get; set; }
    }
}
