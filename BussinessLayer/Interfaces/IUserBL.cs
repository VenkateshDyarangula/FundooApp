using CommonLayer.RequestModel;
using RepositoryLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLayer.Interfaces
{
    public interface IUserBL
    {
        bool Register(RegisterModel user);

    }
}
