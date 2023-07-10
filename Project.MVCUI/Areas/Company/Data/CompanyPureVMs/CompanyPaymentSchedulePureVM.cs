using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MVCUI.Areas.Company.Data.CompanyPureVMs
{
    public class CompanyPaymentSchedulePureVM
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
        public decimal ExchangeRate { get; set; }//Döviz Kuru; Elle Girilebilir(TextBox)
        public string ExchangedType { get; set; }
        public int? SaleID { get; set; }
    }
}
