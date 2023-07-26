using Project.BLL.GenericRepository.BaseRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.ConcRep
{
    public class InvitedGuestAndCompanyRepository:BaseRepository<InvitedGuestAndCompany>
    {
        public override void Update(InvitedGuestAndCompany item)
        {
            item.DataStatus = ENTITIES.Enums.DataStatus.Updated;
            item.UpdatedDate = DateTime.Now;
            InvitedGuestAndCompany toBeUpdated = Find(item.InvitedGuestID, item.CompanyID);
            _db.Entry(toBeUpdated).CurrentValues.SetValues(item);
            Save();
        }
        public override void UpdateRange(List<InvitedGuestAndCompany> list)
        {
            foreach (InvitedGuestAndCompany item in list) Update(item);
        }
    }
}
