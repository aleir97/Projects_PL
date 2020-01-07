//CLASS THAT REPRESENTS A MOBILE PHONE OBJECT
using System;
using System.Collections.Generic;

namespace OOP_EXERCISE{
    public class Mobile_ph{
        //Mobile phone atributes
        private string _model = null;
        private string _manufacturer = null;
        private string _owner = null;
        private int _price = 0;
        
        private Battery _phBattery = null;
        private Screen _phScreen = null;
        private List<Call> _callHistory = null;
    
        public Mobile_ph (string model, string manufacturer, string owner, int price, string batModel, int batIdle, int batTimeHourTalk, 
            string scrSize, string scrColor, BatteryType batteryType){
                this._manufacturer = manufacturer;
                this._owner = owner;
                this._price = price;
                
                this._phBattery = new Battery (batModel, batIdle, batTimeHourTalk, batteryType );
                this._phScreen = new Screen (scrSize, scrColor);
        }

        //Method that adds a call to _callHistory
        public int AddCall(Call new_call){
            
            if (this._callHistory == null)
                this._callHistory = new List<Call>();


            this._callHistory.Add(new_call);

            return 0;
        }

        //Method that calculates the cost of all phone calls
        public double Cost_all_calls(){
            double rst = 0;

            foreach (Call call in this.CallHistory)
                rst += call.Cost_call(); 

            return rst;
        }

        //Method that shows all phone calls info
        public void Ph_calls() {
            int i = 0;
            
            
            if (this.CallHistory == null){
                Console.WriteLine("EMPTY LIST!");

            }else
                foreach (Call elem in this.CallHistory) {
                    i ++;
                    
                    Console.WriteLine("\nph Call Nº: {0}",i);
                    Console.WriteLine("Date ph Call {0}: {1}/{2}/{3}", i, elem.CallDate.Day, elem.CallDate.Month, elem.CallDate.Year);
                    Console.WriteLine("Duration ph Call {0}: {1}",i, elem.CallDrtn);
                    Console.WriteLine("Received at {0}: {1}",i, elem.TmCall);
                    
                }
        }

        //Method that removes all phone calls from _callHistory
        public int Rmv_ph_calls(){
            
            this._callHistory = null;
        
            return 0;
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

        public List<Call> CallHistory{
            get{ return _callHistory; }
            set{ _callHistory = value; }
        }

    }
}







