using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminRequestModels.AddRequestModels
{
    public class AddCompanyTypeRequestModel
    {
        [Required(ErrorMessage = "Şirket tipi girilmesi Zorunludur.")]
        [StringLength(25, ErrorMessage = "Şirket tip adı maksimum 25 karakter olmalıdır.")]
        public string CompanyTypeName { get; set; }
    }
}