using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Interfaces
{
    public interface ITweetDao
    {
        bool AddTweet(Tweet newTweet);
        List<Tweet> GetAllByUserId(int userId);
    }
}
