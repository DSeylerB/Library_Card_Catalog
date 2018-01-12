using System;
using System.Collections.Generic;

namespace Application
{
    public class CardCatalog : Book
    {
        List<Book> BookList = new List<Book>();
        //booklist.foreach to list all books

        /*
        public void AddABook()
        {
            BookList.Add(new Book());

        }
        */

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


            //return;
        }

        

        public void ListAllBooks()
        {
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

        /*
        public ?? Save()
        {

        }
        */
    }
}
