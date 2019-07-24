using Microsoft.AspNetCore.Mvc;
using MyStuff.Models;
using MyStuff.Services;
using MyStuff.ViewModels;

namespace MyStuff.Controllers
{
    public class HomeController : Controller
    {
        private ISoftwareData _softwareData;
        private IBookData _bookdata;
        private IProjectData _projectData;

        public HomeController(ISoftwareData softwareData, IBookData bookdata, IProjectData projectData)
        {

            _softwareData = softwareData;
            _bookdata = bookdata;
            _projectData = projectData; 
        }
        public IActionResult ProfilePage()
        {
            var model = new HomeProfilePageViewModel();
            model.favoriteBooks = _bookdata.GetAll();
            model.softwares = _softwareData.GetAll();

            return View(model);  
        }
        /// <summary>
        /// Currently has all projects, so use AllProjectsViewModel
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var model = new AllProjectsViewModel();
            model.Projects = _projectData.GetAll();
            return View(model);
        }

    }
}
