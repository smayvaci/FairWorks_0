using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.VM.PureVMs
{
    public class ContractDocumentVM
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime InceptionDate { get; set; }
        public DateTime TerminationDate { get; set; }
        public bool IsOverSeas { get; set; }// yurt dışından mı
        public string ContractStatus { get; set; }// yapıldı mı yapılmadı mı
        public string ContractType { get; set; }
    }
}
