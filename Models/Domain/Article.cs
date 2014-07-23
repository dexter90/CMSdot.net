using System;
using System.Runtime.Serialization;

namespace ModelsWCF.Domain
{
    public class Article
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string title { get; set; }
        [DataMember]
        public string shortDescription { get; set; }
        [DataMember]
        public DateTime dateModify { get; set; }
        [DataMember]
        public string content { get; set; }
        [DataMember]
        public string user { get; set; }
        [DataMember]
        public int idArticleType { get; set; }
    }
}
