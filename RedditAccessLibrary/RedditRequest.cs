using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace MattNedrich.RedditAccessLibrary
{
    public class RedditRequest
    {
        public static string GetRequest(string url)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.Headers.Add("user-agent", "C# Reddit Access Library version 0.1");
                string response = webClient.DownloadString(url);
                string rateLimitUsed = webClient.ResponseHeaders["X-Ratelimit-Used"];
                string rateLimitRemaining = webClient.ResponseHeaders["X-Ratelimit-Remaining"];
                string rateLimitReset = webClient.ResponseHeaders["X-Ratelimit-Reset"];
                return response;
            }
        }
    }
}
