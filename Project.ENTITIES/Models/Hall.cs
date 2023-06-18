using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Hall:BaseEntity
    {
        public string HallNumber { get; set; }
        


        //Relational Properties
        public virtual List<FairAndHall> FairAndHalls { get; set; }
        public virtual List<StandArea>StandAreas { get; set; }
    }
}
