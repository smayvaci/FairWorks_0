using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class PaymentSchedule:BaseEntity
    {
        public double DiscountRate { get; set; } //İndirim Oranı
        public int PaymentTerms { get; set; } //Vade Planı;taksit hesaplaması için int tipi verdik.
        public decimal Totalprice { get; set; } // Toplam Tutar
        public decimal RemainingBalance { get; set; }//Kalan Ödeme
        public decimal ExchangeRate { get; set; }//Döviz Kuru; Elle Girilebilir(TextBox)
        public ExchangedType ExchangedType { get; set; }

        //Relational Properties
        public virtual List<Sale> Sales { get; set; }
    }
}
