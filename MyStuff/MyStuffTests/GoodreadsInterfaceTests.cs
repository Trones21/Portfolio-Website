using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyStuff.ExternalInterfaces;
using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Xml;
using System.Linq;
using System;

namespace MyStuff.Tests
{
    [TestClass]
    public class GoodreadsInterfaceTests
    {

        [TestMethod]
        public void UpdateTest()
        {
            var favBooksInterface = new GoodreadsInterface();
            Assert.IsTrue(favBooksInterface.Update());
        }

        [TestMethod]
        public void Manual_UpdateTest()
        {
            var books = new List<Models.Book>();
            var book = new Models.Book();
            book.id = "12345";
            book.DateAdded = DateTime.Now.ToString();
            book.Title = "abcd";
            book.imageLink = "www.website.com";
            books.Add(book);
            try
            {
                GoodreadsInterface.UpdateModel(books);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.StackTrace);
            }
            }

        [TestMethod]
        [DataRow("favorites", "favorites.xml")]
        public void CallApiTest(string list, string filename)
        {
            //Arrange
            var goodreads = new GoodreadsInterface();
            //Act
            bool CallSuccess = goodreads.CallApi(list);
            //Assert
            Assert.IsTrue(CallSuccess);

            var taskStr = goodreads.rawResponse.ReadAsStringAsync();         
            var content = taskStr.Result;

            var xDoc = new XmlDocument();
            xDoc.LoadXml(content);            
        }

        [TestMethod]
        [DataRow("favorites")]
        public void ParseXMLTest(string list)
        {
            //Arrange
            var goodreads = new GoodreadsInterface();
            goodreads.CallApi(list);

            //Act
            bool ParseSuccess = goodreads.ParseXML();

            //Assert to XMLClass
            Assert.IsTrue(ParseSuccess);

            //Assert to Book

        }



        [TestMethod]
        public void Sandbox()
        {
            var Reviews = new List<Review>();
            var filename = "Test.xml";
            var xDoc = new XmlDocument();
            xDoc.Load(filename);
            
            var list = xDoc.DocumentElement.GetElementsByTagName("review");
            XmlSerializer serializer = new XmlSerializer(typeof(Review));

            System.Collections.IEnumerator ienum = list.GetEnumerator();
            while (ienum.MoveNext())
            {                
                var review = (XmlNode)ienum.Current;
                var reviewObj =  (Review)serializer.Deserialize(new XmlNodeReader(review));
                Reviews.Add(reviewObj);
            }

            System.Console.WriteLine("Datacheck");


        }


       
    }
}

