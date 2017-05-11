using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace BusinessLayer.Interfaces
{
    public interface IUserManager
    {
        bool IsExists(UserModel user);
        bool AddUser(UserModel user);

        UserModel GetUser(UserModel user);
    }
}
