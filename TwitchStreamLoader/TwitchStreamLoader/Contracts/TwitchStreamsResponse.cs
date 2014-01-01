using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace TwitchStreamLoader.Contracts
{
    [DataContract]
    public class TwitchStreamsResponse
    {
        [DataMember(Name = "_links")]
        public TwitchStreamResponseLinks Links { get; set; }

        [DataMember(Name = "streams")]
        public Collection<TwitchStream> Streams { get; set; }
    }

    [DataContract]
    public class TwitchStreamsResponseLinks
    {
        [DataMember(Name = "self")]
        public string Self { get; set; }

        [DataMember(Name = "channel")]
        public string Channel { get; set; }
    }
}
