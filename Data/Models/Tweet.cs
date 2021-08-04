using System;
using System.Collections.Generic;

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
    public class TwitterUsers
    {
        public string Name { get; set; }
        public string Profile_image_url { get; set; }
        public string Username { get; set; }
        public long Id { get; set; }
    }
    public class Public_Metrics
    {
        public long Retweet_count { get; set; }
        public long Reply_count { get; set; }
        public long Like_count { get; set; }
    }
}
