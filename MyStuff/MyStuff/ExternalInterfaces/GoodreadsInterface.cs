using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using MyStuff.Models;
using MyStuff.Data;
using Microsoft.EntityFrameworkCore;


namespace MyStuff.ExternalInterfaces
{
    public class GoodreadsInterface
    {
        public HttpContent rawResponse;
        public List<Review> reviews = new List<Review>();
               
        public bool Update()
        {
            try
            {
                CallApi("favorites");
                ParseXML();
                var favoriteBooks = ToBooks();
                UpdateModel(favoriteBooks);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool CallApi(string shelf)
        {
            try {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage responseMessage = client.GetAsync("https://www.goodreads.com/review/list/40458158.xml?key=UOog81i5Z46XBzJweEDFXA&v=2&shelf="+ shelf).Result;
                    rawResponse = responseMessage.Content;
                    return true;
                }
            } catch (HttpRequestException ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
            


        }
        public bool ParseXML()
        {
            try
            {
                var taskStr = rawResponse.ReadAsStringAsync();
                var xDoc = new XmlDocument();
                xDoc.LoadXml(taskStr.Result);

                var list = xDoc.DocumentElement.GetElementsByTagName("review");
                var serializer = new XmlSerializer(typeof(Review));

                System.Collections.IEnumerator ienum = list.GetEnumerator();
                while (ienum.MoveNext())
                {
                    var review = (XmlNode)ienum.Current;
                    var reviewObj = (Review)serializer.Deserialize(new XmlNodeReader(review));
                    reviews.Add(reviewObj);
                }
                return true;
            }
            catch 
            {
                return false;
            }
        }
        public List<Models.Book> ToBooks()
        {

                var Books = new List<Models.Book>();
                foreach (var review in reviews)
                {
                    var book = new Models.Book();
                    book.id = review.Id;
                    book.imageLink = review.Book.Image_url;
                    book.Title = review.Book.Title;
                    book.DateAdded = review.Date_added;

                    Books.Add(book);
                
                }
                return Books;         
        }
        public static void UpdateModel(List<Models.Book> books)
        {
            //var optionsBuilder = new DbContextOptionsBuilder();
            //optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MyStuff;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //optionsBuilder.UseLoggerFactory(MyConsoleLoggerFactory);
            using (var BookCtx = new MyStuffdbContext(new DbContextOptions<MyStuffdbContext>()))
            {
                BookCtx.FavoriteBooks.AddRange(books);
                //BookCtx.FavoriteBooks.UpdateRange(books);
                BookCtx.SaveChanges();
            }
        }

    }


}
