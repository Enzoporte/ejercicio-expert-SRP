using System;
using System.Text;
using System.Collections;

namespace SRP 
{
    // Nueva clase biblioteca para almacenar libros 
    public class Estanteria 
    {
        private ArrayList tituloLibros = new ArrayList();
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
            tituloLibros.Add(book.Title);
        }

        public string Info()
        {
            StringBuilder stringTitulos = new StringBuilder();
            foreach (String titulo in tituloLibros)
            {
                stringTitulos.Append(titulo + ", ");
            }
            return $"La estantería {this.Sector + this.Shelf}, guarda los libros {stringTitulos.ToString()}";
        }

        
    }
}