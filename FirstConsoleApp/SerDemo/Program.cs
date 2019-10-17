using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerDemo
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }

    public class Product
    {
        public string Name { get; set; }
        public DateTime ExpiryDate { get; set; }
        public decimal Price { get; set; }
        public string[] Sizes { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //WriteXML();
            //ReadXML();
            //JsonSerDemo();
            JsonSerializerDemo();
        }

        static void WriteXML()
        {
            Book book = new Book();
            book.Title = "Serialization Overview";
            book.Author = "John Smith";

            XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(Book));

            var path = @"D:\Temp\Book.xml";
            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, book);
            file.Close();
            Console.WriteLine("Finished writing xml...");
        }

        static void ReadXML()
        {
            XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(Book));
            System.IO.StreamReader file = new System.IO.StreamReader(
                @"d:\temp\book.xml");
            Book overview = (Book)reader.Deserialize(file);
            file.Close();

            Console.WriteLine($"{overview.Title} by {overview.Author}");

        }

        static void JsonSerDemo()
        {
            Product product = new Product();

            product.Name = "Apple";
            product.ExpiryDate = new DateTime(2008, 12, 28);
            product.Price = 3.99M;
            product.Sizes = new string[] { "Small", "Medium", "Large" };

            string output = JsonConvert.SerializeObject(product);
            Console.WriteLine(output);
            #region Sample JSON String
            //{
            //  "Name": "Apple",
            //  "ExpiryDate": "2008-12-28T00:00:00",
            //  "Price": 3.99,
            //  "Sizes": [
            //    "Small",
            //    "Medium",
            //    "Large"
            //  ]
            //}
            #endregion

            Product deserializedProduct =
                JsonConvert.DeserializeObject<Product>(output);
            Console.WriteLine(deserializedProduct.Name);
        }

        static void JsonSerializerDemo()
        {            
            Product product = new Product();
            product.Name = "iPad";
            product.ExpiryDate = new DateTime(2008, 12, 28);

            JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter sw = new StreamWriter(@"d:\temp\json.txt"))
            {
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, product);
                    // {"ExpiryDate":new Date(1230375600000),"Price":0}
                }
            }
        }
    }
}
