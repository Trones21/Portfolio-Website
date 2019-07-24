using MyStuff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStuff.ViewModels
{
    public class ProjectEditModel
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string FullDetails { get; set; }
        //public List<Tag> Tags { get; set; }
        public ProgressStatus ProgressStatus { get; set; }
        public WorkorSideProject WorkorSideProject { get; set; }
        public Size Size { get; set; }
        public string GithubLink { get; set; }
        public string ImgURI { get; set; }
        
    }
}
