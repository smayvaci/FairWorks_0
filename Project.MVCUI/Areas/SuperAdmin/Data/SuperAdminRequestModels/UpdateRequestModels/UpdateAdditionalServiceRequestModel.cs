using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminRequestModels.UpdateRequestModels
{
    public class UpdateAdditionalServiceRequestModel
    {
        [Required(ErrorMessage = "Ekstra Servis Adı Zorunludur.")]
        [StringLength(25, ErrorMessage = "Servis adı maksimum 25 karakter olmalıdır.")]
        public int ID { get; set; }
        public bool TapWater { get; set; }// su isteği
        public bool CompressedAir { get; set; }// basınçlı hava
        public bool WasteWater { get; set; }// atık su
        public bool Electricity { get; set; }// elektrik
        public decimal ExtraPrice { get; set; }
    }
}