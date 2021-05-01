using CommonLayer.RequestModel;
using RepositoryLayer.Interfaces;
using RepositoryLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Services
{
    public class UserRL : IUserRL
    {
        public bool Register(RegisterModel user)
        {
            User _user = new User()
            {
                firstname = user.firstname,
                lastname = user.lastname,
                email = user.email,
                password = Encryptedpassword(user.password),
                createdDate = DateTime.Now,

            };
            userContext.Users.Add(_user);
            int result = userContext.SaveChanges();
            if (result <= 0)
            {
                return false;
            }
            else 
            {
                return true;
            }
           
        }
        private static string Encryptedpassword(string password) 
        {
            return password;
        }

        UserContext userContext;
        public UserRL(UserContext userContext)
        {
            this.userContext = userContext;

        }

    }
}
