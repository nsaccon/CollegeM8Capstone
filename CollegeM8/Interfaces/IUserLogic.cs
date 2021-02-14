﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeM8
{
    public interface IUserLogic
    {
        public User CreateUser(User user);
        public User GetUser(string id);
        public User UpdateUser(User user);
        public User Login(Login login);
        public User ChangePassword(ChangePassword login);
    }
}