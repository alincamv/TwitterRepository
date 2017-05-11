using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Models;

namespace DaoHelper.Interfaces
{
    public interface IConvertData
    {
        User ConvertUserToDao(UserModel model);
        UserModel ConvertDaoUserToModel(User user);
        Tweet ConvertTweetToDao(TweetModel model);
        TweetModel ConvertTweetDaoToModel(Tweet tweet);
        List<TweetModel> ConvertTweetDaoToModel(List<Tweet> daoTweets);

    }
}
