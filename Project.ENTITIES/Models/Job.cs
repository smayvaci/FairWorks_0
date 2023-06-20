using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Job:BaseEntity
    {
        public string Name { get; set; }

        //Relational Properties
        public virtual List<Guest>Guests { get; set; }
    }
}