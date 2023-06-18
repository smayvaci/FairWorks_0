using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Sale:BaseEntity
    {
       
        public Decimal SubTotal { get; set; }
        public DateTime SaleDate { get; set; }

        //Relational Properties
        public virtual List<ContractDocument>ContractDocuments { get; set; }


    }
}
