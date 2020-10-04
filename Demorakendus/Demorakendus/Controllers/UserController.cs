using Demorakendus.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demorakendus.Controllers
{
    public class UserController
    {
        public ObjectResult Index()
        {
            var user = new User
            { 
                ID = 1, 
                FirstName = "John",
                LastName = "Smith"
            };
            return new ObjectResult(user);
        }
    }
}
