using System.Collections.Generic;
using DaoHelper.Interfaces;
using DAO;
using Models;

namespace DaoHelper
{
    public class ConvertData:IConvertData
    {
        public User ConvertUserToDao(UserModel model)
        {
            return new User
            {
                Id = model.Id,
                Date_of_birth = model.DateOfBirth,
                Date_of_registration = model.DateOfRegistration,
                Email = model.Email,
                Full_name = model.FullName,
                Location = model.Location,
                Password = model.Password,
                Phone_number = model.PhoneNumber,
                Username = model.Username,
                Avatar =model.Avatar
            };
        }

        public UserModel ConvertDaoUserToModel(User user)
        {
            return new UserModel
            {
                Id = user.Id,
                Username = user.Username,
                FullName = user.Full_name,
                Email = user.Email,
                PhoneNumber = user.Phone_number,
                Password = user.Password,
                Location = user.Location,
                DateOfBirth = user.Date_of_birth,
                DateOfRegistration = user.Date_of_registration,
                Avatar = user.Avatar
            };
        }

        public Tweet ConvertTweetToDao(TweetModel model)
        {
            return new Tweet
            {
                Id = model.Id,
                User_Id = model.UserId,
                Time_of_tweet = model.TimeOfTweet,
                Tweet1 = model.Tweet1,
            };
        }

        public TweetModel ConvertTweetDaoToModel(Tweet tweet)
        {
            return new TweetModel
            {
                Id = tweet.Id,
                UserId = tweet.User_Id,
                TimeOfTweet = tweet.Time_of_tweet,
                Tweet1 = tweet.Tweet1
            };
        }
        public List<TweetModel> ConvertTweetDaoToModel(List<Tweet> daoTweets)
        {
            List<TweetModel> allTweets = new List<TweetModel>();
            foreach (var tweet in daoTweets)
            {
                allTweets.Add(ConvertTweetDaoToModel(tweet));     
            }
            return allTweets;
        }

    }
}