using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FeesBook.ServiceHost.Controllers
{
    public class RegisterController : Controller
    {
        [Route("/index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}