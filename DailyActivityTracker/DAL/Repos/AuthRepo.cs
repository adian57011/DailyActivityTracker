using DailyActivityTracker.DAL.Models;
using DailyActivityTracker.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyActivityTracker.DAL.Repos
{
    public class AuthRepo:Repo
    {
        public bool Signup(User user)
        {
            user.Password = Cipher.Encrypt(user.Password);
            db.Users.Add(user);
            return db.SaveChanges() > 0;
        }

        public bool Login(string name,string pass)
        {
            User user = db.Users.Where(x => x.Username == name && x.Password == Cipher.Decrypt(pass)).FirstOrDefault();
            if(user == null)
            {
                return false;
            }
            return true;
        }

    }
}
