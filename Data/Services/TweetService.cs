using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using RestSharp.Authenticators;
using Tweets.Data;

namespace Tweets.Data
{
    public class TweetService : ITweetService
    {
        public async Task<List<Tweet>> GetTenUserQueriedTweets(string user_query)
        {
            RestClient client = new RestClient("https://api.twitter.com/2/tweets");

            RestRequest request = new RestRequest($"/search/recent?query={user_query}&tweet.fields=public_metrics,created_at&expansions=author_id,attachments.media_keys&media.fields=url&user.fields=name,profile_image_url", DataFormat.Json);

            request.AddParameter("Authorization", string.Format("Bearer " + "AAAAAAAAAAAAAAAAAAAAAKTwRAEAAAAAsF8lPADSnP0qNJCbVlLcHyO61V8%3DtcHGgFrvq3lnihJmBCvqCCSlgVOQCp5Qx5XGt3GZzhuGorJSnd"), ParameterType.HttpHeader);

            var response = await client.GetAsync<TwitterResponse>(request);

            for (int i = 0; i < 10; i++)
            {
                response.Data[i].Name = response.Includes[0].Users[i].Name;
                response.Data[i].Profile_image_url = response.Includes[0].Users[i].Profile_image_url;
                response.Data[i].Username = response.Includes[0].Users[i].Username;
            }

            return response.Data;
        }

        public async Task<List<Tweet>> GetOneAuthorsTweets(string author_id)
        {
            RestClient client = new RestClient("https://api.twitter.com/2/users");

            RestRequest request = new RestRequest($"/{author_id}/tweets?expansions=author_id&tweet.fields=public_metrics,created_at&user.fields=profile_image_url", DataFormat.Json);

            request.AddParameter("Authorization", string.Format("Bearer " + "AAAAAAAAAAAAAAAAAAAAAKTwRAEAAAAAsF8lPADSnP0qNJCbVlLcHyO61V8%3DtcHGgFrvq3lnihJmBCvqCCSlgVOQCp5Qx5XGt3GZzhuGorJSnd"), ParameterType.HttpHeader);

            var response = await client.GetAsync<TwitterResponse>(request);
            
            for (int i = 0; i < 10; i++)
            {
                response.Data[i].Name = response.Includes[0].Users[0].Name;
                response.Data[i].Profile_image_url = response.Includes[0].Users[0].Profile_image_url;
                response.Data[i].Username = response.Includes[0].Users[0].Username;
            }

            return response.Data;
        }
    }
}