using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace TwitchStreamLoader.API {
    [DataContract]
    public class TwitchVideo {
        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "broadcast_id")]
        public long BroadcastId { get; set; }

        [DataMember(Name = "_id")]
        public string Id { get; set; }

        [DataMember(Name = "recorded_at")]
        public string RecordedAt { get; set; }

        [DataMember(Name = "game")]
        public string Game { get; set; }

        [DataMember(Name = "length")]
        public long Length { get; set; }

        [DataMember(Name = "preview")]
        public string Preview { get; set; }

        [DataMember(Name = "url")]
        public string Url { get; set; }

        [DataMember(Name = "embed")]
        public string Embed { get; set; }

        [DataMember(Name = "views")]
        public long Views { get; set; }

        [DataMember(Name = "_links")]
        public TwitchVideoLinks Links { get; set; }

        [DataMember(Name = "channel")]
        public TwitchChannelInfo Channel { get; set; }

        public override string ToString() {
            return Title;
        }
    }

    [DataContract]
    public class TwitchVideoLinks {
        [DataMember(Name = "self")]
        public string Self { get; set; }

        [DataMember(Name = "channel")]
        public string Channel { get; set; }
    }

    [DataContract]
    public class TwitchChannelInfo {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "display_name")]
        public string DisplayName { get; set; }
    }
}
