using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace TwitchStreamLoader.Contracts
{
    [DataContract]
    public class TwitchGame
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "_id")]
        public long Id { get; set; }
        
        [DataMember(Name = "giantbomb_id")]
        public long GiantBombId { get; set; }

        [DataMember(Name = "box")]
        public TwitchArt Box { get; set; }

        [DataMember(Name = "logo")]
        public TwitchArt Logo { get; set; }

        [DataMember(Name = "_links")]
        public TwitchGameLinks Links { get; set; }
    }

    [DataContract]
    public class TwitchGameLinks
    {

    }
}
