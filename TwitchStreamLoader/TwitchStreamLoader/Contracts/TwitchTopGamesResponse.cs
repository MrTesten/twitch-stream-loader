using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace TwitchStreamLoader.Contracts {
    [DataContract]
    public class TwitchTopGamesResponse {
        [DataMember(Name = "total")]
        public long Total { get; set; }

        [DataMember(Name = "_links")]
        public TwitchStreamResponseLinks Links { get; set; }

        [DataMember(Name = "top")]
        public Collection<TwitchTopGame> TopGames { get; set; }
    }

    [DataContract]
    public class TwitchTopGamesResponseLinks {
        [DataMember(Name = "self")]
        public string Self { get; set; }

        [DataMember(Name = "next")]
        public string Next { get; set; }
    }
}
