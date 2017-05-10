using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Interfaces;
using DaoHelper;
using DAO;
using Models;


namespace BusinessLayer
{
    public class TweetManager : ITweetManager
    {
       private TweetDao tweetDao { get; set; }

        private ConvertData convertData {get; set;}

        public TweetManager()
        {
            tweetDao = new TweetDao();
            convertData = new ConvertData();
        }

        public bool AddTweet(TweetModel tweet)
        {
            return tweetDao.AddTweet(convertData.ConvertTweetToDao(tweet));
        }

        public List<TweetModel> GetAllByUserId(int userId)
        {
            return convertData.ConvertTweetDaoToModel(tweetDao.GetAllByUserId(userId));
        }
    }
}
