﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.VM.PureVMs
{
    public class InvitedGuestVM
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string InvitationCard { get; set; }
        public int? CompanyID{ get; set; }
        public string CompanyName { get; set;}

    }
}