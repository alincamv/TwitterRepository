using System.Collections.Generic;

namespace Models
{
    public class UserPageModel
    {
        public UserModel UserModel { get; set; }
        public List<TweetModel> TweetList { get; set; }
    }
}