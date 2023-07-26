using Project.BLL.GenericRepository.BaseRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.ConcRep
{
    public class SectorAndCompanyRepository:BaseRepository<SectorAndCompany>
    {
        public override void Update(SectorAndCompany item)
        {
            item.DataStatus = ENTITIES.Enums.DataStatus.Updated;
            item.UpdatedDate = DateTime.Now;
            SectorAndCompany toBeUpdated = Find(item.CompanyID, item.SectorID);
            _db.Entry(toBeUpdated).CurrentValues.SetValues(item);
            Save();
        }
        public override void UpdateRange(List<SectorAndCompany> list)
        {
            foreach (SectorAndCompany item in list) Update(item); 
        }
    }
}
