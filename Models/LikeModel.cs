using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class LikeModel
    {

        public int Id { get; set; }
        public int UserId { get; set; }
        public bool? ThumbUp { get; set; }
        public int TweetId { get; set; }
        public TweetModel Tweet { get; set; }
    }
}
