using System;
using System.Text;
using System.Collections;

namespace SRP 
{
    // Nueva clase biblioteca para almacenar libros 
    public class Estanteria 
    {
        public ArrayList Libros = new ArrayList();
        public string Sector { get ; }
        public string Shelf { get ; }

        public Estanteria(String sector, String shelf)
        {
            this.Sector = sector;
            this.Shelf = shelf;
        }

        public void ShelveBook(Book book)
        {
            Libros.Add(book);
        }

        public string Info()
        {
            StringBuilder stringLibros = new StringBuilder();
            foreach (Book item in Libros)
            {
                stringLibros.AppendJoin(", ", item.Title);
            }

            return $"La estantería {this.Sector + this.Shelf}, guarda los libros {stringLibros}";

        }

        
    }
}