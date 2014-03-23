using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MattNedrich.RedditAccessLibrary
{
    public class RedditUrlBuilder
    {
        private const string baseUrl = @"http://www.reddit.com";
        private const string subredditBaseUrl = baseUrl + @"/r";
        private const string jsonExtension = @".json";

        public string MakeJsonUrl(string subredditName, Sorting sorting)
        {
            string url = UrlCombine(subredditBaseUrl, subredditName, sorting.ToString().ToLower());
            return string.Concat(url, jsonExtension);
        }

        public string MakeJsonUrl(String subredditName, Sorting sorting, int limit, int count)
        {
            limit = limit > 100 ? 100 : limit; // limit must be between 25 and 100
            string url = UrlCombine(subredditBaseUrl, subredditName, sorting.ToString().ToLower());
            string args = @"?limit=" + limit + @"&count=" + count;
            return string.Concat(url, jsonExtension, args);
        }

        public string MakeJsonUrl(string subredditName, Sorting sorting, int limit)
        {
            limit = limit > 100 ? 100 : limit; // limit must be between 25 and 100
            string url = UrlCombine(subredditBaseUrl, subredditName, sorting.ToString().ToLower());
            string args = @"?limit=" + limit;
            return string.Concat(url, jsonExtension, args);
        }

        private string UrlCombine(params string[] strings)
        {
            StringBuilder combinedUrl = new StringBuilder();
            for(int i=0; i<strings.Length; i++)
            {
                combinedUrl.Append(strings[i]);
                if(i != strings.Length-1)
                    combinedUrl.Append(@"/");
            }
            return combinedUrl.ToString();
        }
    }

    public enum Sorting
    {
        None = 0,
        Top = 1,
        New = 2,
        Hot = 3,
        Controversial = 4,
        Old = 5,
        Random = 6
    }
}
