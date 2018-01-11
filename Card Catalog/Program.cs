using System;

namespace Card_Catalog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Dan!");
        }

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
        }
    }
}
