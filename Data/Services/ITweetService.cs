using System.Collections.Generic;
using System.Threading.Tasks;
using twitter_showcase_app.Data.Models;

namespace Tweets.Data
{
    public interface ITweetService
    {
        Task<List<Tweet>> GetOneAuthorsTweets(string author_id);
        Task<List<Tweet>> GetTenUserQueriedTweets(string user_query);
       
    }
}