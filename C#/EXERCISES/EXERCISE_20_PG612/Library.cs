using System;
using System.Collections.Generic;

namespace EX_20_PG612{
    public class Library {
        private string _name = null;
        private List<Book> _books = null;


        //Constructor
        public Library(string name){
            this._name = name;
        }

        //Method that add a book to the library list
        public int AddBook(Book book){
            
            if (this._books == null){
                this._books = new List<Book>();
            }
            
            this._books.Add(book);
            
            return 0;
        }

        //Method that search a book in library by author and returns it
        public Book Srch_by_Author(String author){
            Book found;

            if (this._books != null){
                
                found = this._books.Find(x => x.Author == author);            
                if (found != null)
                    return found;

            }
            return null;
        }

        //Method that deletes a book in the library
        public bool RmBook(Book book){
            
            return this._books.Remove(book);
            
        }
        
        // Public properties
        public string Name{
            get { return _name; }
            set { _name = value; }
        }
        public List<Book> Books{
            get { return _books; }
            set { _books = value; }
        }


    }
}    