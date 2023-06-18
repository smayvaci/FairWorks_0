using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class CompanyAndCompanyType:BaseEntity
        //JunctionTable
    {
        public int CompanyID { get; set; }
        public int CompanyTypeID { get; set; }

        //Relational Properties
        public virtual Company Company { get; set; }
        public virtual CompanyType CompanyType { get; set; }
    }

}
