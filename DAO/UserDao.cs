using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;

namespace DAO
{
    public class UserDao
    {
        private TwitterDbEntities dbConnection;
        private User existingUser;

        public UserDao()
        {
            existingUser = new User();
        }

        public bool IsExists(User user)
        {
            using (dbConnection = new TwitterDbEntities())
            {
                var dbUser = dbConnection.Users.FirstOrDefault(u => u.Email == user.Email);
                if (dbUser != null && dbUser.Password == user.Password)
                {
                    return true;
                }
                return false;
            }
        }

        public bool AddUser(User newUser)
        {
            using (dbConnection = new TwitterDbEntities())
            {
                var dbUserEmail = dbConnection.Users.FirstOrDefault(u => u.Email == newUser.Email);
                var dbUserUsername = dbConnection.Users.FirstOrDefault(u => u.Username == newUser.Username);
                if (dbUserEmail != null && dbUserUsername != null)
                {
                    if (dbUserEmail.Email == newUser.Email || dbUserUsername.Username == newUser.Username)
                    {
                        return false;
                    }
                }
                else
                {
                    dbConnection.Users.Add(newUser);
                    dbConnection.SaveChanges();
                    return true;
                }

            }
            return true;
        }

        public bool GetDetails(User user)
        {
            using (dbConnection= new TwitterDbEntities())
            {
                existingUser = dbConnection.Users.SingleOrDefault(u => u.Username == user.Username);
                if (existingUser.Username == user.Username)
                {
                    return true;
                }
                
            }
            return false;
        }
    }
}