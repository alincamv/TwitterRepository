using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using Models;
using DAO.Interfaces;

namespace DAO
{
    public class UserDao:IUserDao
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
                existingUser = dbConnection.Users.SingleOrDefault(u => u.Email == user.Email);
                if (existingUser.Email == user.Email)
                {
                    return true;
                }
                
            }
            return false;
        }

        public User GetUserByEmail(User user)
        {
            using (dbConnection= new TwitterDbEntities())
            {
                return existingUser = dbConnection.Users.SingleOrDefault(u => u.Email == user.Email);
                
            }
        }
    }
}