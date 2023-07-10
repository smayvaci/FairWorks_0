using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Areas.IT.Data.ITPureVMs
{
    public class ITEmployeeRolePureVM
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DataStatus { get; set; }
        public string TitleName { get; set; }
        public string Department { get; set; }
        public string Description { get; set; }
    }
}