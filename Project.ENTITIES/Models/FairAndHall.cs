using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class FairAndHall:BaseEntity
    {
        //JunctionTable
        public int FairID { get; set; }
        public int HallID { get; set;}

        //Relational Properties
        public virtual Fair Fair { get; set; }
        public virtual Hall Hall { get; set; }
    }
}
