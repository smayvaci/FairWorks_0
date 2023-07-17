using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminResponseModels.SuperAdminPureVMs
{
    public class SuperStandAreaPureVM
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DataStatus { get; set; }
        public string StandAreaCode { get; set; }// stand area kodu
        public string StandType { get; set; }// stand tipi hazır mı boş mu
        public double Width { get; set; }// genişlik
        public double Height { get; set; }// uzunluk
        public decimal M2Price { get; set; }// m2 fiyatı
        public int? HallID { get; set; }
        public int? HallTypeID { get; set; }//todo bak bi
    }
}