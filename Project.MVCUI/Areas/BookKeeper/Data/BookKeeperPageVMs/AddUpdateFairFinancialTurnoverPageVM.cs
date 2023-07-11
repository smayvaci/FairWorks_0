using Project.MVCUI.Areas.BookKeeper.Data.BookKeeperPureVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.BookKeeper.Data.BookKeeperPageVMs
{
    public class AddUpdateFairFinancialTurnoverPageVM
    {
        public BookFairPureVM Fair { get; set; }
        public List<BookExchangeType> ExchangeTypes { get; set; }
        public List<BookSalePureVM> Sales { get; set; }
    }
}