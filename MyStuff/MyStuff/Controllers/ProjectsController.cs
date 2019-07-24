using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyStuff.Models;
using MyStuff.Services;

namespace MyStuff.Controllers
{
    [Route("[controller]/[action]")]
    public class ProjectsController : Controller
    {
        private IProjectData _projectData;

        public ProjectsController(IProjectData projectData)
        {
            _projectData = projectData;
        }

        public IActionResult All()
        {
            return View();
        }

        public IActionResult Project(string Id)
        {
            var model = _projectData.GetProject(Id);
            return View(model);
        }

        public IActionResult TableauServerAPIWrapper()
        {
            return View();
        }

        public IActionResult CryptoCurrencyWebScraper()
        {
            return View();
        }
    }
}
