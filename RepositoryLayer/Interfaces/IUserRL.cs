using CommonLayer.RequestModel;
using RepositoryLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Interfaces
{
    public interface IUserRL
    {
        bool Register(RegisterModel user);

    }
}
