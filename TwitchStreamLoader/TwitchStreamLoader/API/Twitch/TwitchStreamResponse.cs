using System.Runtime.Serialization;

namespace TwitchStreamLoader.Contracts {
    [DataContract]
    public class TwitchStreamResponse {
        [DataMember(Name = "_links")]
        public TwitchStreamResponseLinks Links { get; set; }

        [DataMember(Name = "stream")]
        public TwitchStream Stream { get; set; }
    }

    [DataContract]
    public class TwitchStreamResponseLinks {
        [DataMember(Name = "self")]
        public string Self { get; set; }

        [DataMember(Name = "channel")]
        public string Channel { get; set; }
    }
}
