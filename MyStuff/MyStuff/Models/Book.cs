using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyStuff.Models
{
        /// <summary>
        /// Take only the elements I want from the GoodReadsFullXMLClasses.cs
        /// </summary>
        public class Book
        {
        public string id { get; set; }
        public string Title { get; set; }
        public string imageLink { get; set; }
        public string DateAdded { get; set;}
        }
    }

