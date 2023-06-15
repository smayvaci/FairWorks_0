using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class EmployeeRole:BaseEntity
    {
        public string TitleName { get; set; }
        public string Department { get; set; }
        public string Description { get; set; }

        //Relational Properties
    }
}
