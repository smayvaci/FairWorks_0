using Project.MVCUI.Areas.BookKeeper.Data.BookKeeperPureVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.BookKeeper.Data.BookKeeperPageVMs
{
    public class ListCompanyPaymentPageVM
    {
        public List<BookCompanyPureVM> Companies { get; set; }
        public List<BookBiddingDocumentPureVM> BiddingDocuments { get; set; }
        public List<BookContractDocumentPureVM> ContractDocuments { get; set; }
        public List<BookPaymentSchedulePureVM> PaymentSchedules { get; set; }
        public List<BookSalePureVM> Sales { get; set; }
        public List<BookExchangeType> ExchangeTypes { get; set; }
        public List<BookFairPureVM> Fairs { get; set; }
    }
}