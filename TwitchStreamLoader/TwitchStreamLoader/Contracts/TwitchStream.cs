using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace TwitchStreamLoader.Contracts
{
    [DataContract]
    public class TwitchStream
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "broadcaster")]
        public string Broadcaster { get; set; }

        [DataMember(Name = "_id")]
        public long Id { get; set; }

        [DataMember(Name = "game")]
        public string Game { get; set; }

        [DataMember(Name = "viewers")]
        public long Viewers { get; set; }

        [DataMember(Name = "preview")]
        public string Preview { get; set; }

        [DataMember(Name = "_links")]
        public TwitchStreamLinks Links { get; set; }

        [DataMember(Name = "channel")]
        public TwitchChannel Channel { get; set; }

        public override string ToString()
        {
            return Channel.Name + ": " + Viewers;
        }
    }

    [DataContract]
    public class TwitchStreamLinks
    {
        [DataMember(Name = "self")]
        public string Self { get; set; }
    }
}
