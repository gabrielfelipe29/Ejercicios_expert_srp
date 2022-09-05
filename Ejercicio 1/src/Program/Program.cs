using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns", "Erich Gamma & Others", "001-034");
            Book book2 = new Book("Pro C#", "Troelsen", "001-035");
            book1.Shelve = new Lib("A", "7");
            book2.Shelve = new Lib("B", "3");


        }
    }
}