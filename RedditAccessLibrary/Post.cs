using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace MattNedrich.RedditAccessLibrary
{
    public class Post : Thing
    {
        [JsonProperty(PropertyName = "domain")]
        public string Domain { get; set; }

        [JsonProperty(PropertyName = "banned_by")]
        public string BannedBy { get; set; }

        [JsonProperty(PropertyName = "subreddit")]
        public string Subreddit { get; set; }

        [JsonProperty(PropertyName = "selftext_html")]
        public string SelftextHtml { get; set; }

        [JsonProperty(PropertyName = "selftext")]
        public string Selftext { get; set; }

        [JsonProperty(PropertyName = "likes")]
        public string Likes { get; set; }

        [JsonProperty(PropertyName = "link_flair_text")]
        public string Link_Flair_Text { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "guilded")]
        public string Guilded { get; set; }
        
        [JsonProperty(PropertyName = "clicked")]
        public string Clicked { get; set; }

        [JsonProperty(PropertyName = "stickied")]
        public string Stickied { get; set; }

        [JsonProperty(PropertyName = "author")]
        public string Author { get; set; }

        [JsonProperty(PropertyName = "score")]
        public string Score { get; set; }
        
        [JsonProperty(PropertyName = "over_18")]
        public string Over18 { get; set; }

        [JsonProperty(PropertyName = "hidden")]
        public string Hidden { get; set; }

        [JsonProperty(PropertyName = "subreddit_id")]
        public string SubredditId { get; set; }

        [JsonProperty(PropertyName = "downs")]
        public string Downs { get; set; }

        [JsonProperty(PropertyName = "saved")]
        public string Saved { get; set; }

        [JsonProperty(PropertyName = "is_self")]
        public string IsSelf { get; set; }

        [JsonProperty(PropertyName = "permalink")]
        public string Permalink { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "created_utc")]
        public string CreatedUtc { get; set; }

        [JsonProperty(PropertyName = "ups")]
        public string Ups { get; set; }

        [JsonProperty(PropertyName = "num_comments")]
        public string NumComments { get; set; }

        [JsonProperty(PropertyName = "visited")]
        public string Visited { get; set; }

        // Not Implemented Fields
        // secure_media_embed
        // approved_by
        // thumbnail
        // edited
        // link_flair_css_class
        // author_flair_css_class
        // created
        // author_flair_text
        // num_reports
        // distinguished
    }
}
