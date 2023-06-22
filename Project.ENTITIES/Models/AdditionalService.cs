using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class AdditionalService:BaseEntity
    {
        public bool TapWater { get; set; }// su isteği
        public bool CompressedAir { get; set; }// basınçlı hava
        public bool WasteWater { get; set; }// atık su
        public bool Electricity { get; set; }// elektrik
        public decimal ExtraPrice { get; set; }

        //Relational Properties
        public virtual List<Sale> Sales { get; set; }
    }
}
