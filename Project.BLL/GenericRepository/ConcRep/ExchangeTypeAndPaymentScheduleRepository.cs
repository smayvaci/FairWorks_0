using Project.BLL.GenericRepository.BaseRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.ConcRep
{
    public class ExchangeTypeAndPaymentScheduleRepository:BaseRepository<ExchangeTypeAndPaymentSchedule>
    {
        public ExchangeTypeAndPaymentScheduleRepository()
        {

        }
        public override void Update(ExchangeTypeAndPaymentSchedule item)
        {
            item.DataStatus = ENTITIES.Enums.DataStatus.Updated;
            item.UpdatedDate = DateTime.Now;
            ExchangeTypeAndPaymentSchedule toBeUpdated = Find(item.ExchangeTypeID, item.PaymentScheduleID);
            _db.Entry(toBeUpdated).CurrentValues.SetValues(item);
            Save();
        }
        public override void UpdateRange(List<ExchangeTypeAndPaymentSchedule> list)
        {
            foreach (ExchangeTypeAndPaymentSchedule item in list) Update(item);
        }
    }
}
