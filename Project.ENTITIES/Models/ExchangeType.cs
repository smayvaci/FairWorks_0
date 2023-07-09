using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class ExchangeType:BaseEntity
    {
        public string CurrencyUnit { get; set; }
        public decimal CurrencyRate { get; set; }

        //Relational Properties
        public virtual List<PaymentSchedule> PaymentSchedules { get; set; }
    }
}
