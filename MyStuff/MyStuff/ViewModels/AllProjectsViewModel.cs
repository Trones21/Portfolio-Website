using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyStuff.Models;

namespace MyStuff.ViewModels
{
    public class AllProjectsViewModel
    {
        public IEnumerable<Project> Projects { get; set;}
    }
}
