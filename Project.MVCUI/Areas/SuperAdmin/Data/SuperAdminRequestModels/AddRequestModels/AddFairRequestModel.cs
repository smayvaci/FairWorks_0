using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminRequestModels.AddRequestModels
{
    public class AddFairRequestModel
    {
        public string EntranceDoor { get; set; }// girişi kapı
        public string ExitDoor { get; set; }// çıkış kapı
        public DateTime StartDate { get; set; }// başlangıç tarihi
        public DateTime ExpiryDate { get; set; }// bitiş tarihi
        public string Location { get; set; }// lokasyon
    }
}