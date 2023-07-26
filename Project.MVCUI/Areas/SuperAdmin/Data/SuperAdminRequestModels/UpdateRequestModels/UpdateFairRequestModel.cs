using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminRequestModels.UpdateRequestModels
{
    public class UpdateFairRequestModel
    {
        [Required(ErrorMessage = "Fuar Adı Zorunludur.")]
        [StringLength(25, ErrorMessage = "Fuar Adı maksimum 25 Karakter Olmalıdır.")]
        public string FairName { get; set; }
        public int ID { get; set; }
        public string EntranceDoor { get; set; }// girişi kapı
        public string ExitDoor { get; set; }// çıkış kapı
        public DateTime StartDate { get; set; }// başlangıç tarihi
        public DateTime ExpiryDate { get; set; }// bitiş tarihi
        public string Location { get; set; }// lokasyon
    }
}