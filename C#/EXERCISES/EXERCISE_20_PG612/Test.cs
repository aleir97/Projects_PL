using System;

namespace EX_20_PG612{
    class Test{
        static void Main(string[] args){
            DateTime release = new DateTime(2017, 1, 18);
            Library lib0 = new Library("CORRY");
            Book book0, AuxBook;


            book0 = new Book("PRINCIPITO", "STEPHEN KING", "AVISA", release, 2345678976543);
            lib0.AddBook(book0);
            book0 = new Book("EL QUIJOTE", "CERVANTES", "GALA", release, 15345534976543);
            lib0.AddBook(book0);
            book0 = new Book("IT", "STEPHEN KING", "NORWA", release, 99486567788876543);
            lib0.AddBook(book0);
            book0 = new Book("Cerave", "FEDERICO", "GILLE", release, 8742677544543);
            lib0.AddBook(book0);
            
            lib0.ShwBooks();
            Console.WriteLine("*******************\n");
            
            
            while ((AuxBook = lib0.Srch_by_Author("STEPHEN KING")) != null){
                    lib0.RmBook(AuxBook);
                    Console.WriteLine(AuxBook);
                    Console.WriteLine("*******************\n");
            }
            
    
            Console.WriteLine("*******************");
            lib0.ShwBooks();

        }
    }
}
