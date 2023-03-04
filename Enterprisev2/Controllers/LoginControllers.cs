using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enterprisev2.Controllers
{
    public class LoginControllers : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
