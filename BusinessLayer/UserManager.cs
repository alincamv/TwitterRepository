using DaoHelper;
using DAO;
using Models;

namespace BusinessLayer
{
    public class UserManager
    {
        public UserManager()
        {
            userDao = new UserDao();
            convertData = new ConvertData();
            passwordEncryption = new PasswordEncryption();
            userModel = new UserModel();
        }

        private UserDao userDao { get; }
        private ConvertData convertData { get; }
        private PasswordEncryption passwordEncryption { get; }
        private UserModel userModel { get; set; }

        public bool IsExists(UserModel user)
        {
            user.Password = passwordEncryption.EncryptPassword(user.Password);
            return userDao.IsExists(convertData.ConvertUserToDao(user));
        }

        public bool AddUser(UserModel user)
        {
            user.Password = passwordEncryption.EncryptPassword(user.Password);
            return userDao.AddUser(convertData.ConvertUserToDao(user));
        }

        public UserModel GetUser(UserModel user)
        {
            userModel= convertData.ConvertDaoUserToModel(userDao.GetUserByEmail(convertData.ConvertUserToDao(user)));
            return userModel;
        }
    }
}