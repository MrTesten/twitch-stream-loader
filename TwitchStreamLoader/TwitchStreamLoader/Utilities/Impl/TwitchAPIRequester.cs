using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;

namespace TwitchStreamLoader.Utilities {
    public class TwitchAPIRequester : APIRequester {
        public TwitchAPIRequester() {
        }

        public T requestObject<T>(string url) {
            T result = default(T);
            try {
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.Accept = Properties.Resources.TwitchAcceptHeader;
                request.Headers["client_id"] = Properties.Resources.ClientId;
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse) {
                    DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(T));
                    result = (T) jsonSerializer.ReadObject(response.GetResponseStream());
                }
            } catch (Exception exception) {
                Console.WriteLine("Invalid Request: " + exception.Message);
            }

            return result;
        }

        public string requestJson(string url) {
            string result = "";
            try {
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.Accept = Properties.Resources.TwitchAcceptHeader;
                request.Headers["client_id"] = Properties.Resources.ClientId;
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse) {
                    result = new StreamReader(response.GetResponseStream()).ReadToEnd();
                }
            } catch (Exception exception) {
                Console.WriteLine("Invalid Request: " + exception.Message);
            }

            return result;
        }
    }
}
