﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Sector:BaseEntity
    {// 1 sektör n firma
     // 1 firma n sektör
        public string SectorName { get; set; }


        //Relational Properties
        public virtual List<SectorAndCompany> SectorAndCompanies { get; set; }


    }
}
