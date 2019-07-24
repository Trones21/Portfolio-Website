using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyStuff.Controllers
{
    /// <summary>
    /// Using attribute based routing so I can make the path any way I want (i.e. does not have to be /Jobs/{file})
    /// </summary>
    [Route("cs/[action]")]
    public class JobsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }
    }
}