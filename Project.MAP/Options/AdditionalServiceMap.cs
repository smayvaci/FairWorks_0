using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class AdditionalServiceMap:BaseMap<AdditionalService>
    {
        public AdditionalServiceMap()
        {
            Property(x => x.ExtraPrice).HasColumnType("money");
        }
    }
}
