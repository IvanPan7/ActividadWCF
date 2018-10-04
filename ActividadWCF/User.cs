using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ActividadWCF
{
    [DataContract]
    public class User
    {
        [DataMember]
        public string NameUser { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string Request { get; set; }
    }
}
