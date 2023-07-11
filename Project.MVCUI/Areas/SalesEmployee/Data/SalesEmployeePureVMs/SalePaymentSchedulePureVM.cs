using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.SalesEmployee.Data.SalesEmployeePureVMs
{
    public class SalePaymentSchedulePureVM
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DataStatus { get; set; }
        public double DiscountRate { get; set; } //İndirim Oranı
        public int PaymentTerms { get; set; } //Vade Planı;taksit hesaplaması için int tipi verdik.
        public decimal Totalprice { get; set; } // Toplam Tutar
        public decimal RemainingBalance { get; set; }//Kalan Ödeme
        public decimal CurrencyRate { get; set; }//Döviz Kuru; Elle Girilebilir(TextBox)
        public string CurrencyUnit { get; set; }
        public int? SaleID { get; set; }
    }
}