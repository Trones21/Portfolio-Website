using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyStuff.Models
{
    public class Project
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string FullDetails { get; set; }
        public List<Tag> Tags { get; set; }
        public ProgressStatus ProgressStatus { get; set; }
        public WorkorSideProject WorkorSideProject { get; set; }
        public Size Size { get; set; }
        public string GithubLink { get; set; }
        public string ImgURI { get; set; }


    }

    public enum ProgressStatus
    {
        Idea,
        InProgress,
        Inactive,
        Complete
    }
    public enum WorkorSideProject
    {
        Work,
        SideProject
    }
    public enum Size
    {
        Small,
        Medium,
        Large,
        Huge
    }


}
