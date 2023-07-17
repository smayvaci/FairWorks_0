using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminRequestModels
{
    public class AddHallRequestModel
    {
        [Required(ErrorMessage = "Salon Kodu Zorunludur.")]
        [StringLength(25, ErrorMessage = "Salon Kodu maksimum 25 karakter olmalıdır.")]
        public string HallNumber { get; set; }
    }
}