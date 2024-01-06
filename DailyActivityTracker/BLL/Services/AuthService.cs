using DailyActivityTracker.DAL.Models;
using DailyActivityTracker.DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyActivityTracker.BLL.Services
{
    public class AuthService
    {
        private AuthRepo dao;

        public AuthService()
        {
            dao = new AuthRepo();
        }
        public bool Signup(User user)
        {
            return dao.Signup(user);
        }
        public bool Login(string name,string pass)
        {
            return dao.Login(name, pass);
        }
    }
}
