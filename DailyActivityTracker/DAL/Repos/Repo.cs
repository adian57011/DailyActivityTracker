﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyActivityTracker.DAL.Repos
{
    public class Repo
    {
        protected DailyActivityContext db;

        public Repo()
        {
            db = new DailyActivityContext();
        }
    }
}
