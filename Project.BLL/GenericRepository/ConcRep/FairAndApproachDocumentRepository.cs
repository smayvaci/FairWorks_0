using Project.BLL.GenericRepository.BaseRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.ConcRep
{
    public class FairAndApproachDocumentRepository:BaseRepository<FairAndApproachDocument>
    {
        public override void Update(FairAndApproachDocument item)
        {
            item.DataStatus = ENTITIES.Enums.DataStatus.Updated;
            item.UpdatedDate = DateTime.Now;
            FairAndApproachDocument toBeUpdated = Find(item.FairID, item.ApproachDocumentID);
            _db.Entry(toBeUpdated).CurrentValues.SetValues(item);
            Save();

        }
        public override void UpdateRange(List<FairAndApproachDocument> list)
        {
            foreach (var item in list) Update(item);
        }
    }
}
