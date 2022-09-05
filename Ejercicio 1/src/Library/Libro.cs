using System;

namespace SRP
{
    public class Book
    {
        /*
        si se cambia la forma de almacenar los libros y se cambia alguna información sobre los libros
        no cumple con SRP. Por lo tanto creo una clase "Lib" para almacenar datos de las librerias.

        */


        public string Title { get; }
        public string Author { get; }
        public string Code { get; }
        public Lib Shelve { get; set; }
        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;

        }

    }
}
