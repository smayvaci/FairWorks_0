using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminRequestModels.AddRequestModels
{
    public class AddAdditionalServiceRequestModel
    {
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