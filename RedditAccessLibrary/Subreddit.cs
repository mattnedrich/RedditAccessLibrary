using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using MattNedrich.RedditAccessLibrary.JsonObjects;

namespace MattNedrich.RedditAccessLibrary
{
    public class Subreddit
    {
        private const int DEFAULT_POST_AMOUNT = 25;
        public string Name { get;  private set; }
        
        public Subreddit(string name)
        {
            Name = name;
        }

        public IEnumerable<Post> GetPosts(Sorting sorting) { return GetPosts(DEFAULT_POST_AMOUNT, sorting); }

        public IEnumerable<Post> GetPosts(int count, int skipCount, Sorting sorting)
        {
            string url = new RedditUrlBuilder().MakeJsonUrl(Name, sorting, count, skipCount);
            string jsonData = RedditRequest.GetRequest(url);
            Thing thing = JsonConvert.DeserializeObject<Thing>(jsonData, new ThingConverter());
            return ((Listing)thing.Data).Items.Select(listingItem => (Post)listingItem.Data);
        }

        public IEnumerable<Post> GetPosts(int count, Sorting sorting)
        {
            string url = new RedditUrlBuilder().MakeJsonUrl(Name, sorting, count);
            string jsonData = RedditRequest.GetRequest(url);
            Thing thing = JsonConvert.DeserializeObject<Thing>(jsonData, new ThingConverter());
            return ((Listing)thing.Data).Items.Select(listingItem => (Post)listingItem.Data);
        }
        
        public IEnumerable<Post> EnumerateForever(Sorting sorting)
        {
            // enumerate posts in chunks of 100
            int chunkSize = 100;
            int enumerated = 0;
            while (true)
            {
                IEnumerable<Post> currentSet = GetPosts(100, enumerated, sorting);
                enumerated += chunkSize;
                foreach (Post p in currentSet)
                    yield return p;
            }
        }
    }
}
