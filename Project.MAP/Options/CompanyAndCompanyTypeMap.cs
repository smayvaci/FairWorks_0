using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class CompanyAndCompanyTypeMap:BaseMap<CompanyAndCompanyType>
    {
        public CompanyAndCompanyTypeMap()
        {
            Ignore(x => x.ID);
            HasKey(x => new
            {
                x.CompanyID,
                x.CompanyTypeID
            });
        }
    }
}
