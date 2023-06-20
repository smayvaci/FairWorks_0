using Project.BLL.GenericRepository.BaseRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.GenericRepository.ConcRep
{
    public class CompanyAndCompanyTypeRepository:BaseRepository<CompanyAndCompanyType>
    {
        public override void Update(CompanyAndCompanyType item)
        {
           // item.DataStatus = ENTITIES.Enums.DataStatus.Updated;
          //  item.UpdatedDate = DateTime.Now;
          //  CompanyAndCompanyType ctype = _db.CompanyAndCompanyTypes.FirstOrDefault(x => x.CompanyID == item.CompanyTypeID && x.CompanyTypeID == item.CompanyTypeID);
         //   CompanyAndCompanyType toBeUpdated = ctype;
          //  _db.Entry(toBeUpdated).CurrentValues.SetValues(item);
           // Save();


            item.DataStatus = ENTITIES.Enums.DataStatus.Updated;
            item.UpdatedDate = DateTime.Now;
            CompanyAndCompanyType toBeUpdated = Find(item.CompanyID, item.CompanyTypeID);
            _db.Entry(toBeUpdated).CurrentValues.SetValues(item);
            Save();
           }
    }
}
