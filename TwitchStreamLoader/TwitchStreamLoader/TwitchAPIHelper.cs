using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchStreamLoader.Contracts;

namespace TwitchStreamLoader
{
    public class TwitchAPIHelper
    {
        private TwitchAPI twitchAPI;
        private string searchURL;
        private string streamsURL;

        public TwitchAPIHelper()
        {
            twitchAPI = TwitchAPIRequester.makeRequest<TwitchAPI>(Properties.Resources.TwitchApiUrl);
            if (twitchAPI != null && twitchAPI.Links != null)
            {
                searchURL = twitchAPI.Links.Search;
                streamsURL = twitchAPI.Links.Streams;
            }
        }

        public TwitchStream getStream(string channel)
        {
            TwitchStream stream = null;
            if (streamsURL != null)
            {
                TwitchStreamResponse response = TwitchAPIRequester.makeRequest<TwitchStreamResponse>(streamsURL + "/" + channel);
                stream = response.Stream;
            }

            return stream;
        }

        public Collection<TwitchStream> getStreams()
        {
            Collection<TwitchStream> streams = null;
            if (streamsURL != null)
            {
                TwitchStreamsResponse response = TwitchAPIRequester.makeRequest<TwitchStreamsResponse>(streamsURL);
                streams = response.Streams;
            }

            return streams;
        }
    }
}
