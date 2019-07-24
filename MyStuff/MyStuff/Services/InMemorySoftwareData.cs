using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyStuff.Models;

namespace MyStuff.Services
{
    public class InMemorySoftwareData : ISoftwareData
    {
        List<Software> _softwares;

        public InMemorySoftwareData()
        {
            _softwares = new List<Software>
            {
                new Software { Name = "Tableau", Description = "Analytics"},
                new Software { Name = "Visio", Description = "Visual Diagramming" },
                new Software { Name = "Greenshot", Description = "Screenshot tool"}
            };
        }

        public IEnumerable<Software> GetAll()
        {
            return _softwares.OrderBy(s => s.Name);
        }
    }
}
