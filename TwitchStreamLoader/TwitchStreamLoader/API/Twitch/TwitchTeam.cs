using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace TwitchStreamLoader.API {
    [DataContract]
    public class TwitchTeam {
        [DataMember(Name = "info")]
        public string Info { get; set; }

        [DataMember(Name = "_links")]
        public TwitchTeamLinks Links { get; set; }

        [DataMember(Name = "background")]
        public string Background { get; set; }

        [DataMember(Name = "banner")]
        public string Banner { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "_id")]
        public long Id { get; set; }

        [DataMember(Name = "updated_at")]
        public string UpdatedAt { get; set; }

        [DataMember(Name = "display_name")]
        public string DisplayName { get; set; }

        [DataMember(Name = "created_at")]
        public string CreatedAt { get; set; }

        [DataMember(Name = "logo")]
        public string Logo { get; set; }

        [DataContract]
        public class TwitchTeamLinks {
            [DataMember(Name = "self")]
            public string Self { get; set; }
        }
    }
}
