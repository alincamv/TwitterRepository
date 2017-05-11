using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace BusinessLayer.Interfaces
{
    public interface ITweetManager
    {
        bool AddTweet(TweetModel tweet);
        List<TweetModel> GetAllByUserId(int userId);

    }
}
