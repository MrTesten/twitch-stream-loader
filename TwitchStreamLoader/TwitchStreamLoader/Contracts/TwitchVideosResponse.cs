using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace TwitchStreamLoader.Contracts {
    [DataContract]
    public class TwitchVideosResponse {
        [DataMember(Name = "total")]
        public long Total { get; set; }

        [DataMember(Name = "_links")]
        public TwitchStreamResponseLinks Links { get; set; }

        [DataMember(Name = "videos")]
        public Collection<TwitchVideo> Videos { get; set; }
    }

    [DataContract]
    public class TwitchVideosResponseLinks {
        [DataMember(Name = "self")]
        public string Self { get; set; }

        [DataMember(Name = "next")]
        public string Next { get; set; }
    }
}
