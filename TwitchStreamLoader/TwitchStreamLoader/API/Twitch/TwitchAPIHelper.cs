using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchStreamLoader.Utilities;

namespace TwitchStreamLoader.API {
    public class TwitchAPIHelper {
        private APIRequester apiRequester;
        private TwitchAPI twitchAPI;
        private string topGamesUrl;
        private string searchUrl;
        private string streamsUrl;

        public TwitchAPIHelper() {
            apiRequester = new TwitchAPIRequester();
            twitchAPI = apiRequester.requestObject<TwitchAPI>(Properties.Resources.TwitchApiUrl);
            if (twitchAPI != null && twitchAPI.Links != null) {
                searchUrl = twitchAPI.Links.Search;
                streamsUrl = twitchAPI.Links.Streams;
                topGamesUrl = Properties.Resources.TwitchApiUrl + Properties.Resources.TwitchTopGamesUrl;
            }
        }

        public TwitchStream getStream(string channel) {
            TwitchStream stream = null;
            if (streamsUrl != null) {
                TwitchStreamResponse response = apiRequester.requestObject<TwitchStreamResponse>(streamsUrl + "/" + channel);
                stream = response.Stream;
            }

            return stream;
        }

        public Collection<TwitchStream> getStreams() {
            Collection<TwitchStream> streams = null;
            if (streamsUrl != null) {
                TwitchStreamsResponse response = apiRequester.requestObject<TwitchStreamsResponse>(streamsUrl);
                streams = response.Streams;
            }

            return streams;
        }

        public Collection<TwitchStream> getStreams(string game) {
            string gameSearchParameter = "?game=" + game.Replace(' ', '+');
            Collection<TwitchStream> streams = null;
            if (streamsUrl != null) {
                TwitchStreamsResponse response = apiRequester.requestObject<TwitchStreamsResponse>(streamsUrl + gameSearchParameter);
                if (response != null) {
                    streams = response.Streams;
                }
            }

            return streams;
        }

        public Collection<TwitchStream> getStreams(Collection<string> channels) {
            Collection<TwitchStream> streams = null;
            if (channels != null && channels.Count > 0) {
                string channelSearchParameter = "?channel=" + string.Join(",", channels.ToArray());
                if (streamsUrl != null) {
                    TwitchStreamsResponse response = apiRequester.requestObject<TwitchStreamsResponse>(streamsUrl + channelSearchParameter);
                    if (response != null) {
                        streams = response.Streams;
                    }
                }
            }

            return streams;
        }

        public Collection<TwitchTopGame> getTopGames() {
            Collection<TwitchTopGame> topGames = null;
            if (topGamesUrl != null) {
                TwitchTopGamesResponse response = apiRequester.requestObject<TwitchTopGamesResponse>(topGamesUrl);
                if (response != null) {
                    topGames = response.TopGames;
                }
            }

            return topGames;
        }

        public Collection<TwitchVideo> getVideos(string channel, bool broadcasts) {
            Collection<TwitchVideo> videos = null;
            if (channel != null) {
                string broadcastFlag = broadcasts ? "true" : "false";
                TwitchVideosResponse response = apiRequester.requestObject<TwitchVideosResponse>("https://api.twitch.tv/kraken/channels/" + channel + "/videos?broadcasts=" + broadcastFlag);
                if (response != null) {
                    videos = response.Videos;
                }
            }

            return videos;
        }
    }
}
