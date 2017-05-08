using System.Web.Mvc;
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
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignIn(UserModel user)
        {
            if (userManager.IsExists(user))
            {
                Session["UserName"] = user.FullName;
                if (Session["UserID"] != null)
                {
                    return View("UserPage");
                }
            }
            return View(user);
        }

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
                    return View("UserPage", user);
                }
            }
            return View(user);
        }

        [HttpGet]
        public ActionResult UserPage(UserPageModel userPageModel)
        {
            if (userManager.IsExists(userPageModel.UserModel))
            {
                return View(userPageModel);
            }
            return View();
        }
    }
}