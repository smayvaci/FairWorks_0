﻿using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class SaleMap:BaseMap<Sale>
    {
        public SaleMap()
        {
            Property(x => x.SubTotal).HasColumnName("money");
        }
    }
}
