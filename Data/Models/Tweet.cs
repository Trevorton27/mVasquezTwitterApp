using System;
using System.Collections.Generic;
using twitter_showcase_app.Data.Models;

namespace Tweets.Data
{
    public class TwitterResponse {
        public List<Tweet> Data { get; set; }
        public List<Includes> Includes { get; set; }
    }

    public class Tweet
    {
        public long Id { get; set; }
        public long Author_id { get; set; }
        public List<Public_Metrics> Public_metrics { get; set; }
        public DateTime Created_at { get; set; }
        public string Text { get; set; }
        public string Name { get; set; }
        public string Profile_image_url { get; set; }
        public string Username { get; set; }
    }

    public class Includes
    {
        public List<TwitterUsers> Users { get; set; }
    }
}
