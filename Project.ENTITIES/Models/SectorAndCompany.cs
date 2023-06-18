using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class SectorAndCompany:BaseEntity
    {   //JunctionTable
        public string SectorID { get; set; }
        public string CompanyID { get; set; }

        //Relational Properties
        public virtual Sector  Sector{ get; set; }
        public virtual Company Company { get; set; }
    }
}
