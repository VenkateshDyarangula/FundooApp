using BussinessLayer.Interfaces;
using CommonLayer.RequestModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundooApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserBL bl;

        public UserController(IUserBL bl)
        {
            this.bl = bl;

        }
        [HttpPost]
        public IActionResult Register([FromBody] RegisterModel user ) 
        {
           
            bool result = bl.Register(user);
            if (result == true)
            {
                return this.Ok(new { success = true, Message = "User Registartion is Success" }); 
            }
            else 
            {
                return this.BadRequest(new { success = false, Message = "User Registartion is Failed" }); 

            }



        }
    }
}

