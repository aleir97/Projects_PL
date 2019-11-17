using System;


namespace OOP_EXERCISE{
    public enum BatteryType{
       LiIon,
        NiMH,
        NiCd,
        Graphene
    }
    public class Battery{
        // Battery atributes
        private string _batModel = null;
        private int _batIdle = 0;
        private int _batTimeHourTalk = 0;
        private BatteryType _batteryType;
      
        // Constructor 
        public Battery (string batModel, int batIdle, int batTimeHourTalk, BatteryType batteryType){
            this._batModel = batModel;
            this._batIdle = batIdle;
            this._batTimeHourTalk = batTimeHourTalk; 
            this._batteryType = batteryType;
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

        public BatteryType Battery_Type{
            get { return _batteryType; }
            set { _batteryType = value; }
        }    
    }
}





