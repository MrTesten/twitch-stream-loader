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
        private string topGamesUrl;
        private string searchUrl;
        private string streamsUrl;

        public TwitchAPIHelper()
        {
            twitchAPI = TwitchAPIRequester.requestObject<TwitchAPI>(Properties.Resources.TwitchApiUrl);
            if (twitchAPI != null && twitchAPI.Links != null)
            {
                searchUrl = twitchAPI.Links.Search;
                streamsUrl = twitchAPI.Links.Streams;
                topGamesUrl = Properties.Resources.TwitchApiUrl + Properties.Resources.TwitchTopGamesUrl;
            }
        }

        public TwitchStream getStream(string channel)
        {
            TwitchStream stream = null;
            if (streamsUrl != null)
            {
                TwitchStreamResponse response = TwitchAPIRequester.requestObject<TwitchStreamResponse>(streamsUrl + "/" + channel);
                stream = response.Stream;
            }

            return stream;
        }

        public Collection<TwitchStream> getStreams()
        {
            Collection<TwitchStream> streams = null;
            if (streamsUrl != null)
            {
                TwitchStreamsResponse response = TwitchAPIRequester.requestObject<TwitchStreamsResponse>(streamsUrl);
                streams = response.Streams;
            }

            return streams;
        }

        public Collection<TwitchStream> getStreams(string game)
        {
            string gameSearchParameter = "?game=" + game.Replace(' ', '+');
            Collection<TwitchStream> streams = null;
            if (streamsUrl != null)
            {
                TwitchStreamsResponse response = TwitchAPIRequester.requestObject<TwitchStreamsResponse>(streamsUrl + gameSearchParameter);
                streams = response.Streams;
            }

            return streams;
        }

        public Collection<TwitchTopGame> getTopGames()
        {
            Collection<TwitchTopGame> topGames = null;
            if (topGamesUrl != null)
            {
                TwitchTopGamesResponse response = TwitchAPIRequester.requestObject<TwitchTopGamesResponse>(topGamesUrl);
                topGames = response.TopGames;
            }

            return topGames;
        }
    }
}
