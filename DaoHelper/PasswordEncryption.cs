using System.Security.Cryptography;
using System.Text;

namespace DaoHelper
{
    public class PasswordEncryption
    {
        public string EncryptPassword(string password)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(Encoding.ASCII.GetBytes(password));
            var result = md5.Hash;
            var stringBuilder = new StringBuilder();
            foreach (var t in result)
            {
                stringBuilder.Append(t.ToString("x2"));
            }
            return stringBuilder.ToString();
        }
    }
}