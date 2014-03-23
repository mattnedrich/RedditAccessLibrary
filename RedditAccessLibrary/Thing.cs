using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MattNedrich.RedditAccessLibrary
{
    /// <summary>Base class in the Reddit API. Most API items inherit from Thing</summary>
    public class Thing
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        [JsonProperty(PropertyName = "data")]
        public Thing Data { get; set; }
    }
}
