using BusinessLayer.Interfaces;
using DaoHelper;
using DAO;
using DAO.Interfaces;
using Models;

namespace BusinessLayer
{
    public class UserManager: IUserManager
    {
        public UserManager()
        {
            userDao = new UserDao();
            convertData = new ConvertData();
            passwordEncryption = new PasswordEncryption();
        }

        private IUserDao userDao { get; }
        private ConvertData convertData { get; }
        private PasswordEncryption passwordEncryption { get; }

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
    }
}