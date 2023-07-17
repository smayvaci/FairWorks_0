﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminRequestModels
{
    public class AddFairRequestModel
    {
        [Required(ErrorMessage = "Fuar Adı Zorunludur.")]
        [StringLength(25, ErrorMessage = "Fuar Adı maksimum 25 Karakter Olmalıdır.")]
        public string EntranceDoor { get; set; }// girişi kapı
        public string ExitDoor { get; set; }// çıkış kapı
        public DateTime StartDate { get; set; }// başlangıç tarihi
        public DateTime ExpiryDate { get; set; }// bitiş tarihi
        public string Location { get; set; }// lokasyon
    }
}