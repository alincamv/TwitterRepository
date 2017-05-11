using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAO.Interfaces
{
    public interface IUserDao
    {
        bool IsExists(User user);
        bool AddUser(User newUser);
        bool GetDetails(User user);
        User GetUserByEmail(User user);
    }
}

