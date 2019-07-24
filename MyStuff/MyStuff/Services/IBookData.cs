using MyStuff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStuff.Services
{
    //Defines all the methods to Retrieve, update, and Delete Books 
    public interface IBookData
    {
        IEnumerable<Book> GetAll();
    }
}
