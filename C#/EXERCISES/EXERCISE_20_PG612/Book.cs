using System;

namespace EX_20_PG612{
    public class Book{
        private string _title = null;
        private string _author = null;
        private string _publisher = null;
        DateTime _release;
        private long _isbn;

        //Constructor
        public Book(string title, string author, string publisher, DateTime release, long isbn){
            this._title = title;
            this._author = author;
            this._publisher = publisher;
            this._release = release;
            this._isbn = isbn;
        }

        //To string override
        public override string ToString(){
            string str = this._title +" writed by: "+this._author +"\nPublished by: "+this._publisher
                +" on "+this._release.Day +"/"+this._release.Month +"/"+this._release.Year +"\nISBN: "+this._isbn ;

            
            return str;
        }




        // Public properties
        public string Title{
            get { return _title; }
            set { _title = value; }
        }
        public string Author{
            get { return _author; }
            set { _author = value; }
        }
        public string Publisher{
            get { return _publisher; }
            set { _publisher = value; }
        }
        public DateTime Release{
            get { return _release; }
            set { _release = value; }
        }
        public long ISBN{
            get { return _isbn; }
            set { _isbn = value; }
        }
    }
}    