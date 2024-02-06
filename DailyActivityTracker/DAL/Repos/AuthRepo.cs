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
            List<User> users = db.Users.Where(x => x.Username == name).ToList();
            foreach(User user in users )
            {
                string decrypt = Cipher.Decrypt(user.Password);
                if(pass == decrypt) { return true; }
            }           
            return false;
        }

    }
}
