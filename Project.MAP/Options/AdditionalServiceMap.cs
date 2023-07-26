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
            Property(x => x.ElectricityPrice).HasColumnType("money");
            Property(x => x.WasteWaterPrice).HasColumnType("money");
            Property(x => x.TapWaterPrice).HasColumnType("money");
            Property(x => x.CompressedAirPrice).HasColumnType("money");
            Property(x => x.SubTotalPrice).HasColumnType("money");
        }
    }
}
