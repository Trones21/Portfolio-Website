using MyStuff.Data;
using MyStuff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStuff.Services
{
    public class SqlProjectData : IProjectData
    {
        private MyStuffdbContext _context;

        public SqlProjectData(MyStuffdbContext context)
        {
            _context = context;
        }

        public Project Add(Project project)
        {
            _context.Projects.Add(project);
            _context.SaveChanges();
            return project;
        }

        public Project GetProject(string id)
        {
            return _context.Projects.FirstOrDefault(p => p.Id == id);
        }
        public IEnumerable<Project> GetAll()
        {
            return _context.Projects.OrderBy(p => p.Title);
        }

        
    }
}
