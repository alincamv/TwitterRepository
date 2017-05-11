using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TweetModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime TimeOfTweet { get; set; }
        public string Tweet1 { get; set; }
        public virtual ICollection<LikeModel> Likes { get; set; }
        public UserModel User { get; set; }
    }
}
