using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SalesEmployee.Data.SalesEmployeePureVMs
{
    public class SaleFairPureVM
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DataStatus { get; set; }
        public string EntranceDoor { get; set; }// girişi kapı
        public string ExitDoor { get; set; }// çıkış kapı
        public DateTime StartDate { get; set; }// başlangıç tarihi
        public DateTime ExpiryDate { get; set; }// bitiş tarihi
        public string Location { get; set; }// lokasyon
        
    }
}