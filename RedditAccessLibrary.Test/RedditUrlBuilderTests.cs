using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace RedditAccessLibrary.Test
{
    [TestFixture]
    public class RedditUrlBuilderTests
    {
        RedditUrlBuilder urlBuilder;
        [SetUp]
        public void Setup()
        {
            urlBuilder = new RedditUrlBuilder();
        }
        
        [Test]
        public void Test_Top_Sorting_Url_Construction()
        {
            string expected = @"http://www.reddit.com/r/worldnews/top.json";
            string actual = urlBuilder.MakeJsonUrl("worldnews", Sorting.Top);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Top_Sorting_With_Limit_Url_Construction()
        {
            string expected = @"http://www.reddit.com/r/worldnews/top.json?limit=50";
            string actual = urlBuilder.MakeJsonUrl("worldnews", Sorting.Top, 50);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Limit_Greater_Than_100_Is_Capped_Url_Construction()
        {
            string expected = @"http://www.reddit.com/r/worldnews/top.json?limit=100";
            string actual = urlBuilder.MakeJsonUrl("worldnews", Sorting.Top, 105);
            Assert.AreEqual(expected, actual);
        }
    }
}
