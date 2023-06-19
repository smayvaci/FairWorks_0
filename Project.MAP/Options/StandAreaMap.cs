using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class StandAreaMap:BaseMap<StandArea>
    {
        public StandAreaMap()
        {
            Property(x => x.M2Price).HasColumnName("money");
        }
    }
}
