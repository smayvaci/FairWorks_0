using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminRequestModels.UpdateRequestModels
{
    public class UpdateHallRequestModel
    {

        [Required(ErrorMessage = "Salon Kodu Zorunludur.")]
        [StringLength(25, ErrorMessage = "Salon Kodu maksimum 25 karakter olmalıdır.")]
        public int ID { get; set; }
        public string HallNumber { get; set; }
    }
}