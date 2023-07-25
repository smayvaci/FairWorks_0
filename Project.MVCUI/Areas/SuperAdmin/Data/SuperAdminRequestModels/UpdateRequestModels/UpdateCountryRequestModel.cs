using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminRequestModels.UpdateRequestModels
{
    public class UpdateCountryRequestModel
    {
        public int ID { get; set; }
        
        [Required(ErrorMessage = "Ülke Adı Zorunludur.")]
        [StringLength(25, ErrorMessage = "Sektör adı maksimum 25 karakter olmalıdır.")]
        public string CountryName { get; set; }
    }
}