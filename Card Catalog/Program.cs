using Application;
using System;
using System.Collections.Generic;

namespace Card_Catalog
{
    class Program
    {
        static CardCatalog cc = null;
        static void Main(string[] args)
        {
            cc = new CardCatalog();
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }
        public static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) List all books");
            Console.WriteLine("2) Add a book");
            Console.WriteLine("3) Save and Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                cc.ListAllBooks();
                return true;
            }
            else if (result == "2")
            {
                cc.AddABook();
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

    }
}