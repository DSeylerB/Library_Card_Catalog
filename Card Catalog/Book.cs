using System;

namespace Application
{
    public class Book
    {
        public string Title
        {
            get;
            set;
        }

        public string Author
        {
            get;
            set;
        }

        public string ISBN
        {
            get;
            set;
        }

        public string PublicationYear
        {
            get;
            set;
        }

        public Book(string title = "", string author = "", string isbn = "", string pubYear = "")
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            PublicationYear = pubYear;
        }
    }
}
