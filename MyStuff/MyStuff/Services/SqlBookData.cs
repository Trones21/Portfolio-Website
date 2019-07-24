using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyStuff.Data;
using MyStuff.Models;

namespace MyStuff.Services
{
    public class SqlBookData : IBookData
    {
        private MyStuffdbContext _context;

        public SqlBookData(MyStuffdbContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> GetAll()
        {
            return _context.FavoriteBooks.OrderBy(b => b.DateAdded);
        }
    }
}
