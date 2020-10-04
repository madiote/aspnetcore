using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demorakendus.Controllers
{
    public class ApiController
    {
        public string Index()
        {
            return "See on rakendusliidese leht.";
        }

        public bool Friday()
        {
            return DateTime.Now.DayOfWeek == DayOfWeek.Friday;
        }

        public int Double(int id)
        {
            return id * 2;
        }
    }
}
