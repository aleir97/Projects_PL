using System;

namespace EXERCISE_2_PG851
{
    class Worker: Human
    {
        private double _wage;
        private TimeSpan _hWorked;

        //Constructor
        public Worker(string first_name, string last_name, double wage, TimeSpan hWorked) : base (first_name, last_name)    
        {
            this._wage = wage;
            this._hWorked = hWorked;
        } 

        public double calculate_hourly_wage ()
        {
            double rst = 0;

            rst =   this._wage / this._hWorked.TotalHours;

            return rst;
        }

        //Properties
        public double Wage 
        {
            get { return _wage;  }
            set { _wage = value; }
        }

        public string FirstNm 
        {
            get { return _firstNm;  }
            set { _firstNm = value; }
        }

        public string LastNm 
        {
            get { return _lastNm;  }
            set { _lastNm = value; }
        }
    }
}