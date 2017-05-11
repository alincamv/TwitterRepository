using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;
using Models;

namespace TwitterRepository.Controllers
{
    public class TweetsController : Controller
    {
        private TweetManager tweetManager;
        private TweetModel tweetModel;

        public TweetsController()
        {
            tweetManager = new TweetManager();
            tweetModel= new TweetModel();
        }

        // GET: Tweet
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TweetPage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TweetPage(TweetModel tweet)
        {
            tweet.UserId = Convert.ToInt32(Session["UserId"].ToString());
            tweet.TimeOfTweet = DateTime.Now;
            tweetManager.AddTweet(tweet);
            return View();
        }
        public List<TweetModel> GetAllTweets(UserModel userModel)
        {
            return (List<TweetModel>)(userModel.Tweet = tweetManager.GetAllByUserId(userModel.Id));           
        }




    }
}