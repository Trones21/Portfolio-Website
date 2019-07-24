using MyStuff.Models;
using System.Collections.Generic;

namespace MyStuff.Services
{
    //Defines all the methods to Retrieve, update, and Delete Softwares
    public interface ISoftwareData
    {
        IEnumerable<Software> GetAll();
    }
}