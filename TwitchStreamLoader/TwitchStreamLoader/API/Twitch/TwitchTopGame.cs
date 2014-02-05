using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace TwitchStreamLoader.API {
    [DataContract]
    public class TwitchTopGame {
        [DataMember(Name = "viewers")]
        public long Viewers { get; set; }

        [DataMember(Name = "channels")]
        public long Channels { get; set; }

        [DataMember(Name = "game")]
        public TwitchGame Game { get; set; }
    }
}
