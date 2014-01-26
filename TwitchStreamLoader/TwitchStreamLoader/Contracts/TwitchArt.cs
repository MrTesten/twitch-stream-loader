using System.Runtime.Serialization;

namespace TwitchStreamLoader.Contracts {
    [DataContract]
    public class TwitchArt {
        [DataMember(Name = "template")]
        public string Template { get; set; }

        [DataMember(Name = "small")]
        public string Small { get; set; }

        [DataMember(Name = "medium")]
        public string Medium { get; set; }

        [DataMember(Name = "large")]
        public string Large { get; set; }
    }
}
