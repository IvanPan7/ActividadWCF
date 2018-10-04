using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ActividadWCF
{
    [DataContract]
    public class ProductResponse
    {
        [DataMember]
        public bool IsApproved { get; set; }
        [DataMember]
        public string ProductReference { get; set; }

    }
}
