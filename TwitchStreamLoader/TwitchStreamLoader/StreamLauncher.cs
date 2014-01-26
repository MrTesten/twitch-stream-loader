using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Diagnostics;

namespace TwitchStreamLoader {
    public sealed class StreamLauncher {
        private StreamLauncher() {
        }

        public static void launchStream(string url, string quality) {
            try {
                ProcessStartInfo processStartInfo = new ProcessStartInfo();
                processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                processStartInfo.CreateNoWindow = true;
                processStartInfo.UseShellExecute = false;
                processStartInfo.RedirectStandardOutput = true;
                processStartInfo.RedirectStandardError = true;
                processStartInfo.FileName = Properties.Resources.LivestreamerExecutable;
                processStartInfo.Arguments = "--player-args \"{filename} \\-\\-qt-minimal-view \\-\\-no-video-title-show \\-\\-no-qt-name-in-title\"";
                processStartInfo.Arguments += " " + url;
                processStartInfo.Arguments += " " + quality;

                Process livestreamerProcess = Process.Start(processStartInfo);
            } catch (Exception exception) {
                Console.WriteLine("Caught exception: " + exception.Message);
            }
        }
    }
}
