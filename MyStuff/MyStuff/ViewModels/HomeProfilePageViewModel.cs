using MyStuff.Models;
using System.Collections.Generic;

namespace MyStuff.ViewModels
{
    public class HomeProfilePageViewModel
    {
        public IEnumerable<Book> favoriteBooks { get; set; }
        public IEnumerable<Software> softwares { get; set; }
    }
}
