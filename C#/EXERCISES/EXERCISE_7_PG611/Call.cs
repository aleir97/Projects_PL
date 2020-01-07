using System;

namespace OOP_EXERCISE{
    public class Call{
        private DateTime _callDate;
        private TimeSpan _tmCall;
        private TimeSpan _callDrtn;
    
        public Call(DateTime callDate, TimeSpan tmCall, TimeSpan callDrtn){
            this._callDate = callDate;
            this._tmCall = tmCall;
            this._callDrtn = callDrtn;
        }
    
        //
        public double Cost_call(){
            double rst = 0;

            rst = (this._callDrtn.TotalMinutes) * 0.37;

            return rst;
        }

        public DateTime CallDate{
            get{ return _callDate; }
            set{ _callDate = value; }
        } 

        public TimeSpan TmCall{
            get{ return _tmCall; }
            set{ _tmCall = value; }
        }

        public TimeSpan CallDrtn{
            get{ return _callDrtn; }
            set{ _callDrtn = value; }
        }
    }
}