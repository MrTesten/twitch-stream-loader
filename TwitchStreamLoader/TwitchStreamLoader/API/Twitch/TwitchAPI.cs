using System.Runtime.Serialization;

namespace TwitchStreamLoader.API {
    [DataContract]
    public class TwitchAPI {
        [DataMember(Name = "_links")]
        public TwitchAPILinks Links { get; set; }

        [DataContract]
        public class TwitchAPILinks {
            [DataMember(Name = "teams")]
            public string Teams { get; set; }

            [DataMember(Name = "channel")]
            public string Channel { get; set; }

            [DataMember(Name = "user")]
            public string User { get; set; }

            [DataMember(Name = "ingests")]
            public string Ingests { get; set; }

            [DataMember(Name = "streams")]
            public string Streams { get; set; }

            [DataMember(Name = "search")]
            public string Search { get; set; }
        }
    }
}
