using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Contract:BaseEntity
    {
        public DateTime ContractTime { get; set; }
        public bool IsOverSeas { get; set; }
        public ContractType ContractType { get; set; }
        public DateTime ContractDeadLine { get; set; }
        public ContractStatus ContractStatus { get; set; }

        //Relational properties

    }
}
