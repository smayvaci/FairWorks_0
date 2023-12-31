﻿using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class StandArea :BaseEntity
    {
        public string StandType;

        public string StandAreaCode { get; set; }
       
        public bool IsReadyMadeConstruction { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public decimal M2Price { get; set; }
        public int? HallID { get; set; }

        //Relational Properties
        public virtual Hall Hall { get; set; }
    }
}
