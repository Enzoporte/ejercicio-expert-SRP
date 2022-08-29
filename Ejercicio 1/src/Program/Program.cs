using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Estanteria A7 = new Estanteria("A", "7");
            Estanteria B3 = new Estanteria("B", "3");

            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");

            A7.ShelveBook(book1);
            B3.ShelveBook(book2);
            A7.ShelveBook(book2);

            Console.WriteLine(A7.Info());


            //book1.ShelveBook(book1,"A","7");
            //book2.ShelveBook(book2,"B","3");

        }
    }
}