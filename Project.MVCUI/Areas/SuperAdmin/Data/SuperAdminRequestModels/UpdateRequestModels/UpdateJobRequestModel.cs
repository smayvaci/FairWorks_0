using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminRequestModels.UpdateRequestModels
{
    public class UpdateJobRequestModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Meslek Adı Zorunludur.")]
        [StringLength(25, ErrorMessage = "Meslek adı maksimum 25 karakter olmalıdır.")]
        public string JobName { get; set; }
    }
}