using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchStreamLoader.Utilities {
    interface APIRequester {
        T requestObject<T>(string url);
        string requestJson(string url);
    }
}
