//CLASS THAT REPRESENTS A MOBILE PHONE OBJECT
using System;


namespace OOP_EXERCISE{
    public class Mobile_ph{
        //Mobile phone atributes
        private string _model = null;
        private string _manufacturer = null;
        private string _owner = null;
        private int _price = 0;
        
        private Battery _phBattery = null;
        private Screen _phScreen = null;
    
        public Mobile_ph (string model, string manufacturer, string owner, int price, string batModel, int batIdle, int batTimeHourTalk, 
            string scrSize, string scrColor, BatteryType batteryType ){
                this._model = model;
                this._manufacturer = manufacturer;
                this._owner = owner;
                this._price = price;
                
                this._phBattery = new Battery (batModel, batIdle, batTimeHourTalk, batteryType );
                this._phScreen = new Screen (scrSize, scrColor);
        }

        // Public properties
        public string Model{
            get { return _model; }
            set { _model = value; }
        }

        public string Manufacturer{
            get { return _manufacturer; }
            set { _manufacturer = value; }
        }

        public string Owner{
            get { return _owner; }
            set { _owner = value; }
        }

        public int Price{
            get { return _price; }
            set { _price = value; }
        }
    
        public Battery PhBattery{
            get { return _phBattery; }
            set { _phBattery = value; }
        }

        public Screen PhScreen{
            get { return _phScreen; }
            set { _phScreen = value; }
        }
    }
}







