using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.VM.PureVMs
{
    public class CountryVM
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CountryName { get; set; }
        public string Region { get; set; }
        public string Language { get; set; }
        public string PhoneCode { get; set; }
        public string Description { get; set; }

    }
}
