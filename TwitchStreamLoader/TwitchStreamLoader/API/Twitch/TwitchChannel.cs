using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace TwitchStreamLoader.API {
    [DataContract]
    public class TwitchChannel {
        [DataMember(Name = "mature")]
        public string Mature { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "display_name")]
        public string DisplayName { get; set; }

        [DataMember(Name = "game")]
        public string Game { get; set; }

        [DataMember(Name = "_id")]
        public long Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "created_at")]
        public string CreatedAt { get; set; }

        [DataMember(Name = "updated_at")]
        public string UpdatedAt { get; set; }

        [DataMember(Name = "logo")]
        public string Logo { get; set; }

        [DataMember(Name = "banner")]
        public string Banner { get; set; }

        [DataMember(Name = "video_banner")]
        public string VideoBanner { get; set; }

        [DataMember(Name = "background")]
        public string Background { get; set; }

        [DataMember(Name = "url")]
        public string Url { get; set; }

        [DataMember(Name = "_links")]
        public TwitchChannelLinks Links { get; set; }

        [DataMember(Name = "teams")]
        public Collection<TwitchTeam> Teams { get; set; }

        [DataContract]
        public class TwitchChannelLinks {
            [DataMember(Name = "self")]
            public string Self { get; set; }

            [DataMember(Name = "follows")]
            public string Follows { get; set; }

            [DataMember(Name = "commercial")]
            public string Commercial { get; set; }

            [DataMember(Name = "stream_key")]
            public string StreamKey { get; set; }

            [DataMember(Name = "chat")]
            public string Chat { get; set; }

            [DataMember(Name = "features")]
            public string Features { get; set; }

            [DataMember(Name = "subscriptions")]
            public string Subscriptions { get; set; }

            [DataMember(Name = "editors")]
            public string Editors { get; set; }

            [DataMember(Name = "videos")]
            public string Videos { get; set; }
        }
    }
}
