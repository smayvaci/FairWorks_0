using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.BookKeeper.Data.BookKeeperPureVMs
{
    public class BookExchangeType
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DataStatus { get; set; }
        public string CurrencyUnit { get; set; }
        public decimal CurrencyRate { get; set; }
    }
}