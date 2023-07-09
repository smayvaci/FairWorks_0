using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class ExchangeTypeAndPaymentSchedule:BaseEntity
    {
        public int ExchangeTypeID { get; set; }
        public int PaymentScheduleID { get; set; }

        //Relational Properties
        public virtual ExchangeType ExchangeType { get; set; }
        public virtual PaymentSchedule PaymentSchedule { get; set; }
    }
}
