﻿using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
   public class FairAndApproachDocumentMap:BaseMap<FairAndApproachDocument>
    {
        public FairAndApproachDocumentMap()
        {
            Ignore(x => x.ID);
            HasKey(x=> new
            { 
                x.FairID,
                x.ApproachDocumentID
            });
        }
    }
}
