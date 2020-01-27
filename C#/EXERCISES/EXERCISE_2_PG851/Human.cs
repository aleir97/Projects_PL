using System;


//Class that represents a human being with "first name" and "last name"

namespace EXERCISE_2_PG851
{
    class Human
    {
        protected string _firstNm = null;
        protected string _lastNm = null;

        public Human(string first_name, string last_name)
        {
            this._firstNm = first_name;
            this._lastNm = last_name;
        }   
    }
}