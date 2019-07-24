using MyStuff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStuff.Services
{
    public interface IProjectData
    {

        IEnumerable<Project> GetAll();
        Project Add(Project project);
        Project GetProject(string id);


    }
}
