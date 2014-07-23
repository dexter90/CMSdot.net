using System;
using System.Runtime.Serialization;

namespace ModelsWCF.Domain
{
    public class Language
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string language { get; set; }
        [DataMember]
        public string image { get; set; }
        [DataMember]
        public int isActive { get; set; }
    }
}
