using System;


namespace OOP_EXERCISE{

    public class Battery{

        // Battery atributes
        private string _batModel;
        private int _batIdle;
        private int _batTimeHourTalk;

        // Constructor 
        public Battery (string batModel, int batIdle, int batTimeHourTalk){
            this._batModel = batModel;
            this._batIdle = batIdle;
            this._batTimeHourTalk = batTimeHourTalk; 
        }
        
        // Public properties
        public string BatModel{
            get { return _batModel; }
            set { _batModel = value; }
        }

        public int BatIdle{
            get { return _batIdle; }
            set { _batIdle = value; }
        }

        public int BatTimeHourTalk{
            get { return _batTimeHourTalk; }
            set { _batTimeHourTalk = value; }
        }
    
    }
}






