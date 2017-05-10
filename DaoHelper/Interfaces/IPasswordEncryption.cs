using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoHelper.Interfaces
{
    public interface IPasswordEncryption
    {
        string EncryptPassword(string password);
    }
}
