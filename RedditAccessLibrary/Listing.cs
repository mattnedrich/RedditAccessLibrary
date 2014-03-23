using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace MattNedrich.RedditAccessLibrary
{
    public class Listing : Thing
    {
        [JsonProperty(PropertyName = "before")]
        public string Before { get; set; }

        [JsonProperty(PropertyName = "after")]
        public string After { get; set; }

        [JsonProperty(PropertyName = "modhash")]
        public string Modhash { get; set; }

        [JsonProperty(PropertyName = "children")]
        public IEnumerable<Thing> Items { get; set; }
    }
}
