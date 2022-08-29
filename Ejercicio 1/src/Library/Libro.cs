using System;

namespace SRP
{
    public class Book
    {
        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }

        // Estas propiedades creo que no deberían de ser responsabilidades del libro, si no de otra clase
        // Que se encargue de ordenar esos libros o de indicar a donde tiene que ir qué libro.

        /* public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; } */

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }



        // Este método añadiría otra responsabilidad al libro. 

        /* public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }
        */

    }

}
