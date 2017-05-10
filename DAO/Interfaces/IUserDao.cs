﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Interfaces
{
    public interface IUserDao
    {
        bool IsExists(User user);
        bool AddUser(User newUser);
        bool GetDetails(User user);
    }
}

