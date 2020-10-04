using Demorakendus.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demorakendus.Controllers
{
    public class UserController : Controller
    {
        public ViewResult Index()
        {
            var user = new User
            { 
                ID = 1, 
                FirstName = "John",
                LastName = "Smith"
            };
            return View(user);
        }
    }
}
