using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Linq;
using System.Threading.Tasks;

namespace MyStuff.ExternalInterfaces
{

        [XmlRoot(ElementName = "id")]
        public class Id
        {
            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }
            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "text_reviews_count")]
        public class Text_reviews_count
        {
            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }
            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "image_url")]
        public class Image_url
        {
            [XmlAttribute(AttributeName = "nophoto")]
            public string Nophoto { get; set; }
            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "small_image_url")]
        public class Small_image_url
        {
            [XmlAttribute(AttributeName = "nophoto")]
            public string Nophoto { get; set; }
            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "author")]
        public class Author
        {
            [XmlElement(ElementName = "id")]
            public string Id { get; set; }
            [XmlElement(ElementName = "name")]
            public string Name { get; set; }
            [XmlElement(ElementName = "role")]
            public string Role { get; set; }
            [XmlElement(ElementName = "image_url")]
            public Image_url Image_url { get; set; }
            [XmlElement(ElementName = "small_image_url")]
            public Small_image_url Small_image_url { get; set; }
            [XmlElement(ElementName = "link")]
            public string Link { get; set; }
            [XmlElement(ElementName = "average_rating")]
            public string Average_rating { get; set; }
            [XmlElement(ElementName = "ratings_count")]
            public string Ratings_count { get; set; }
            [XmlElement(ElementName = "text_reviews_count")]
            public string Text_reviews_count { get; set; }
        }

        [XmlRoot(ElementName = "authors")]
        public class Authors
        {
            [XmlElement(ElementName = "author")]
            public Author Author { get; set; }
        }

        [XmlRoot(ElementName = "work")]
        public class Work
        {
            [XmlElement(ElementName = "id")]
            public string Id { get; set; }
            [XmlElement(ElementName = "uri")]
            public string Uri { get; set; }
        }

        [XmlRoot(ElementName = "book")]
        public class Book
        {
            [XmlElement(ElementName = "id")]
            public Id Id { get; set; }
            [XmlElement(ElementName = "isbn")]
            public string Isbn { get; set; }
            [XmlElement(ElementName = "isbn13")]
            public string Isbn13 { get; set; }
            [XmlElement(ElementName = "text_reviews_count")]
            public Text_reviews_count Text_reviews_count { get; set; }
            [XmlElement(ElementName = "uri")]
            public string Uri { get; set; }
            [XmlElement(ElementName = "title")]
            public string Title { get; set; }
            [XmlElement(ElementName = "title_without_series")]
            public string Title_without_series { get; set; }
            [XmlElement(ElementName = "image_url")]
            public string Image_url { get; set; }
            [XmlElement(ElementName = "small_image_url")]
            public string Small_image_url { get; set; }
            [XmlElement(ElementName = "large_image_url")]
            public string Large_image_url { get; set; }
            [XmlElement(ElementName = "link")]
            public string Link { get; set; }
            [XmlElement(ElementName = "num_pages")]
            public string Num_pages { get; set; }
            [XmlElement(ElementName = "format")]
            public string Format { get; set; }
            [XmlElement(ElementName = "edition_information")]
            public string Edition_information { get; set; }
            [XmlElement(ElementName = "publisher")]
            public string Publisher { get; set; }
            [XmlElement(ElementName = "publication_day")]
            public string Publication_day { get; set; }
            [XmlElement(ElementName = "publication_year")]
            public string Publication_year { get; set; }
            [XmlElement(ElementName = "publication_month")]
            public string Publication_month { get; set; }
            [XmlElement(ElementName = "average_rating")]
            public string Average_rating { get; set; }
            [XmlElement(ElementName = "ratings_count")]
            public string Ratings_count { get; set; }
            [XmlElement(ElementName = "description")]
            public string Description { get; set; }
            [XmlElement(ElementName = "authors")]
            public Authors Authors { get; set; }
            [XmlElement(ElementName = "published")]
            public string Published { get; set; }
            [XmlElement(ElementName = "work")]
            public Work Work { get; set; }
        }

        [XmlRoot(ElementName = "shelf")]
        public class Shelf
        {
            [XmlAttribute(AttributeName = "name")]
            public string Name { get; set; }
            [XmlAttribute(AttributeName = "exclusive")]
            public string Exclusive { get; set; }
            [XmlAttribute(AttributeName = "id")]
            public string Id { get; set; }
            [XmlAttribute(AttributeName = "review_shelf_id")]
            public string Review_shelf_id { get; set; }
            [XmlAttribute(AttributeName = "sortable")]
            public string Sortable { get; set; }
        }

        [XmlRoot(ElementName = "shelves")]
        public class Shelves
        {
            [XmlElement(ElementName = "shelf")]
            public List<Shelf> Shelf { get; set; }
        }

        [XmlRoot(ElementName = "review")]
        public class Review
        {
            [XmlElement(ElementName = "id")]
            public string Id { get; set; }
            [XmlElement(ElementName = "book")]
            public Book Book { get; set; }
            [XmlElement(ElementName = "rating")]
            public string Rating { get; set; }
            [XmlElement(ElementName = "votes")]
            public string Votes { get; set; }
            [XmlElement(ElementName = "spoiler_flag")]
            public string Spoiler_flag { get; set; }
            [XmlElement(ElementName = "spoilers_state")]
            public string Spoilers_state { get; set; }
            [XmlElement(ElementName = "shelves")]
            public Shelves Shelves { get; set; }
            [XmlElement(ElementName = "recommended_for")]
            public string Recommended_for { get; set; }
            [XmlElement(ElementName = "recommended_by")]
            public string Recommended_by { get; set; }
            [XmlElement(ElementName = "started_at")]
            public string Started_at { get; set; }
            [XmlElement(ElementName = "read_at")]
            public string Read_at { get; set; }
            [XmlElement(ElementName = "date_added")]
            public string Date_added { get; set; }
            [XmlElement(ElementName = "date_updated")]
            public string Date_updated { get; set; }
            [XmlElement(ElementName = "read_count")]
            public string Read_count { get; set; }
            [XmlElement(ElementName = "body")]
            public string Body { get; set; }
            [XmlElement(ElementName = "comments_count")]
            public string Comments_count { get; set; }
            [XmlElement(ElementName = "url")]
            public string Url { get; set; }
            [XmlElement(ElementName = "link")]
            public string Link { get; set; }
            [XmlElement(ElementName = "owned")]
            public string Owned { get; set; }
        }

    }


