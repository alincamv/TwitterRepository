using System.IO;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI;
using BusinessLayer;
using Models;

namespace TwitterRepository.Controllers
{
    public class UsersController : Controller
    {
        public UsersController()
        {
            userManager = new UserManager();
        }

        private UserManager userManager { get; }

        // GET: User
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignIn(UserModel user)
        {
            if (userManager.IsExists(user))
            {
                Session["UserEmail"] = user.Email;
                Session["UserId"] = userManager.GetUser(user).Id;
                if (Session["UserEmail"] != null)
                {
                    return View("UserPage", UserPageSetUp(user));
                }

                //if (FormsAuthentication.Authenticate(user.Email, user.Password))
                //{
                //    FormsAuthentication.RedirectFromLoginPage(user.Email,false);
                //}

                Session["UserEmail"] = user.Email;
                return View("UserPage", UserPageSetUp(user));
            }
            return View("UserPage");
        }
        [AllowAnonymous]
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(UserModel user)
        {
            if (ModelState.IsValid)
            {
                if (userManager.AddUser(user))
                {

                    return View("UserPage", UserPageSetUp(user));

                    Session["UserName"] = user.Username;
                    return View("UserPage",UserPageSetUp(user));

                }
            }
            return View(user);
        }

        [HttpGet]
        [Authorize]
        public ActionResult UserPage(UserPageModel userPageModel)
        {
            if (userManager.IsExists(userPageModel.UserModel))
            {
                return View(UserPageSetUp(userPageModel.UserModel));
            }
            return View();
        }

        [Authorize]
        public UserPageModel UserPageSetUp(UserModel user)
        {
            Session["UserEmail"] = user.Email;
            
            UserPageModel userPageModel = new UserPageModel
            {
                UserModel = userManager.GetUser(user),
                TweetList = new TweetsController().GetAllTweets(user)
            };

            return userPageModel;
        }           
    }
}