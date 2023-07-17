using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminRequestModels
{
    public class UpdateStandAreaRequestModel
    {

        [Required(ErrorMessage = "Stand Alan Kodu Zorunludur.")]
        [StringLength(25, ErrorMessage = "Stand Alan Kodu maksimum 25 karakter olmalıdır.")]
        public int ID { get; set; }
        public string StandAreaCode { get; set; }// stand area kodu
        public string StandType { get; set; }// stand tipi hazır mı boş mu
        public double Width { get; set; }// genişlik
        public double Height { get; set; }// uzunluk
        public decimal M2Price { get; set; }// m2 fiyatı
    }
}