using System;
using System.Collections.Generic;

namespace Application
{
    public class CardCatalog
    {
        List<Book> booklist = new List<Book>();
        //booklist.foreach to ist all books

        public void AddABook()
        {
            booklist.Add(new Book());

        }

        private static string AddABook(string title, string author, string isbn, string pubYear)
        {
            this.Title = title;
            this.Author = author;
            this.ISBN = isbn;
            this.PublicationYear = pubYear;

            Console.WriteLine("Enter Title: ");
            title = Console.ReadLine();
            Console.WriteLine("Enter Author: ");
            author = Console.ReadLine();
            Console.WriteLine("Enter ISBN: ");
            isbn = Console.ReadLine();
            Console.WriteLine("Enter Publication Year: ");
            pubYear = Console.ReadLine();


            return;
        }

        public string ListAllBooks()
        {
            //var list = new List<string>(Enumerable.Range(0, 50));
            //list.ForEach(Console.WriteLine)
        }
    }
}
