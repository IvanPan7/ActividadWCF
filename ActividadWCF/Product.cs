using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ActividadWCF
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public int IDProduct { get; set; }
        [DataMember]
        public string NameProduct { get; set; }
        [DataMember]
        public string Description{ get; set; }
        [DataMember]
        public int IDCategory { get; set; }
    }
}
