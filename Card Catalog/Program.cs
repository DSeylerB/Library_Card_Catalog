using System;

namespace Card_Catalog
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) List all books");
            Console.WriteLine("2) Add a book");
            Console.WriteLine("3) Save and Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                ListAllBooks();
                return true;
            }
            else if (result == "2")
            {
                AddABook();
                return true;
            }
            else if (result == "3")
            {
                return false; //Need to add a method that saves then exits (serialization)
            }
            else
            {
                return true;
            }
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
