using System;


namespace OOP_EXERCISE{
    public class Screen{
        // Screen atributes
        private string _scrSize = null;
        private string _scrColor = null;

        // Constructor
        public Screen (string scrSize, string scrColor){
            this._scrSize = scrSize;
            this._scrColor = scrColor;
        }

        // Public properties
        public string ScrSize{
            get { return _scrSize; }
            set { _scrSize = value; }
        }

        public string ScrColor{
            get { return _scrColor; }
            set { _scrColor = value; }
        }
    }
}





