using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPureVMs
{
    public class SuperAdditionalServicePureVM
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DataStatus { get; set; }
        public bool TapWater { get; set; }// su isteği
        public bool CompressedAir { get; set; }// basınçlı hava
        public bool WasteWater { get; set; }// atık su
        public bool Electricity { get; set; }// elektrik
        public decimal ExtraPrice { get; set; }
        public int? SaleID { get; set; }
    }
}