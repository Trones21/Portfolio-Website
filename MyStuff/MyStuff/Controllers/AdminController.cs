using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyStuff.Models;
using MyStuff.Services;
using MyStuff.ViewModels;

namespace MyStuff.Controllers
{

    public class AdminController : Controller
    {
        private IProjectData _projectData;

        public AdminController(IProjectData projectData)
        {
            _projectData = projectData;
        }


        [HttpGet]
        public IActionResult AdminConsole()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminConsole(ProjectEditModel model)
        {
            var newProject = new Project();

            newProject.Title = model.Title;
            newProject.ShortDescription = model.ShortDescription;
            newProject.FullDetails = model.FullDetails;
            newProject.ProgressStatus = model.ProgressStatus;
            newProject.WorkorSideProject = model.WorkorSideProject;
            newProject.Size = model.Size;
            newProject.ImgURI = model.ImgURI;
            newProject.GithubLink = model.GithubLink;

             _projectData.Add(newProject);

            return View("AddSuccess", newProject);
        }
    }
}