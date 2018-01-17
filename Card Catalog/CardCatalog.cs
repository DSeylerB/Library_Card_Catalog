using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

namespace Application
{
    public class CardCatalog : Book
    {
        List<Book> BookList = new List<Book>();
        
        public void AddABook()
        {
            Console.WriteLine("Enter Title: ");
            Title = Console.ReadLine();
            Console.WriteLine("Enter Author: ");
            Author = Console.ReadLine();
            Console.WriteLine("Enter ISBN: ");
            ISBN = Console.ReadLine();
            Console.WriteLine("Enter Publication Year: ");
            PublicationYear = Console.ReadLine();

            BookList.Add(new Book(Title, Author, ISBN, PublicationYear));
        }
                
        public void ListAllBooks()
        {
            Console.Clear();
            foreach (var Book in BookList)
            {
                Console.WriteLine("Title: {0}, Author: {1}, ISBN #: {2}, Publication Year: {3}", 
                    Book.Title, 
                    Book.Author, 
                    Book.ISBN, 
                    Book.PublicationYear);
            }
            Console.WriteLine("Press the Enter key to return to the menu");
            Console.ReadLine();
        }

        public void Save(string fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Create))
            {
                XmlSerializer XML = new XmlSerializer(typeof(List<Book>));
                XML.Serialize(stream, this.BookList);
            }
        }
                
        public void Load(string fileName)
        {

            using (var stream = new FileStream(fileName, FileMode.Open))
            {
                XmlSerializer XML = new XmlSerializer(typeof(List<Book>));
                BookList = (List<Book>)XML.Deserialize(stream);
            }
        }
    }
}
