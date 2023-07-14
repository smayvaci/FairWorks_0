using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminRequestModels
{
    public class AddCountryRequestModel
    {
        [Required(ErrorMessage = "Ülke Adı Zorunludur.")]
        [StringLength(25, ErrorMessage = "Sektör adı maksimum 25 karakter olmalıdır.")]
        public string CountryName { get; set; }
    }
}