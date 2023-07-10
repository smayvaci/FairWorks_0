using Project.BLL.DesignPatterns.GenericRepository.BaseRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.ConcRep
{
    public class FairAndGuestRepository:BaseRepository<FairAndGuest>
    {
        public override void Update(FairAndGuest item)
        {
            item.DataStatus = ENTITIES.Enums.DataStatus.Updated;
            item.UpdatedDate = DateTime.Now;
            FairAndGuest toBeUpdated = Find(item.FairID, item.GuestID);
            _db.Entry(toBeUpdated).CurrentValues.SetValues(item);
            Save();
        }
        public override void UpdateRange(List<FairAndGuest> list)
        {
            foreach (FairAndGuest item in list) Update(item);
        }
    }
}
