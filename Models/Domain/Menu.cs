using System;
using System.Runtime.Serialization;

namespace ModelsWCF.Domain
{
    [DataContract]
    public class Menu
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string namePosition { get; set; }
        [DataMember]
        public string link { get; set; }
        [DataMember]
        public int childId { get; set; }
        [DataMember]
        public string descirpion { get; set; }
        [DataMember]
        public int idLanguage { get; set; }
    }
}
