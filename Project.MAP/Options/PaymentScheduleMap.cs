﻿using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class PaymentScheduleMap:BaseMap<PaymentSchedule>
    {
        public PaymentScheduleMap()
        {
            Property(x => x.TotalPrice).HasColumnType("money");
            Property(x=>x.RemainingBalance).HasColumnType("money");
           
        }
    }
}
