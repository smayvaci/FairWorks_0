using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Employee:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string TrID { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? EmployeeRoleID { get; set; }
        public int? ReportTo { get; set; }

        //Relational Properties
        public virtual List<ApproachDocument>ApproachDocuments { get; set; }
        public virtual EmployeeRole EmployeeRole { get; set; }
        public virtual List<Employee> Employees { get; set; }


    }
}
