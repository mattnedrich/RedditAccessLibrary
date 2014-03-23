Reddit Access Library
================

C# Reddit Access Library

### Overview
This is a partial wrapper around the reddit API that focuses on allowing the user to read/crawl reddit.

### Usage Model
```
Subreddit worldNews = new Subreddit("worldnews");
// The code below will never stop enumerating posts
foreach(Post post in worldNews.EnumerateForever(Sorting.Top))
    Console.WriteLine(post.Title);
```