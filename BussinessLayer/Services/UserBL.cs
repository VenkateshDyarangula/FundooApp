using BussinessLayer.Interfaces;
using CommonLayer.RequestModel;
using RepositoryLayer.Interfaces;
using RepositoryLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLayer.Services
{
    public class UserBL : IUserBL
    {

        private readonly IUserRL rl;

        public UserBL(IUserRL rl)
        {
            this.rl = rl;

        }

        public bool Register(RegisterModel user)
        {
            return this.rl.Register(user);
        }
    }
}
