using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Interfaces;
using Models;

namespace DAO
{
    public class TweetDao:ITweetDao
    {
        private TwitterDbEntities dbConnection;
        public bool AddTweet(Tweet newTweet)
        {
            using (dbConnection = new TwitterDbEntities())
            {
                dbConnection.Tweets.Add(newTweet);
                dbConnection.SaveChanges();
                return true;
            }
        }

        public List<Tweet> GetAllByUserId(int userId)
        {
            using (dbConnection = new TwitterDbEntities())
            {
               return dbConnection.Tweets.Where(t => t.User_Id == userId).ToList();
            }

        }

        }
}
