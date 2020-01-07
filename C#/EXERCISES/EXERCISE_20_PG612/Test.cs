using System;

namespace EX_20_PG612{
    class Test{
        static void Main(string[] args){
            DateTime now = new DateTime(2017, 1, 18);
            
            Book book0 = new Book("PRINCIPITO", "ALEJANDRO", "AVISA", now, 2345678976543);
            Book AuxBook;
            
            Library lib0 = new Library("CORRY");
            


            lib0.AddBook(book0);
            
            if ((AuxBook = lib0.Srch_by_Author("ALEJANDRO")) != null)
                Console.WriteLine(AuxBook);


            


        }
    }
}
