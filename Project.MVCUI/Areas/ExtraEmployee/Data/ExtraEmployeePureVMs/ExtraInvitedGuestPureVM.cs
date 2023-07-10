using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.ExtraEmployee.Data.ExtraEmployeePureVMs
{
    public class ExtraInvitedGuestPureVM
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DataStatus { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string InvitationCard { get; set; }
        
    }
}