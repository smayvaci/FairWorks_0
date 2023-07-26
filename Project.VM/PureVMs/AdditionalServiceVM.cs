using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.VM.PureVMs
{
    public class AdditionalServiceVM
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DataStatus { get; set; }
        public bool TapWater { get; set; }// su isteği
        public decimal TapWaterPrice { get; set; }
        public bool CompressedAir { get; set; }// basınçlı hava
        public decimal CompressedAirPrice { get; set; }
        public bool WasteWater { get; set; }// atık su
        public decimal WasteWaterPrice { get; set; }
        public bool Electricity { get; set; }// elektrik
        public decimal ElectricityPrice { get; set; }
        public decimal SubTotalPrice { get; set; }

    }
}
