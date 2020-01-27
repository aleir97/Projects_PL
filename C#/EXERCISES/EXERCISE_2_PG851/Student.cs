using System;
using System.Collections.Generic;

namespace EXERCISE_2_PG851
{
    class Student : Human{

        private double _mark;

        //Constructor
        public Student(string first_name, string last_name, double mark) : base(first_name, last_name)
        {
            this._mark = mark;
        }
    
        //Properties
        public double Mark
        {
            get { return _mark;  }
            set { _mark = value; }
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

public class Mark : IComparable<Mark>
{
    // Implement the generic CompareTo method with the Mark 
    // class as the Type parameter. 
    //
    public Mark(double mark)
    {
        this.Mark_val = mark;
    }

    public int CompareTo(Mark other)
    {
        // If other is not a valid object reference, this instance is greater.
        if (other == null) return 1;
        
        // The Mark comparison depends on the comparison of 
        // the underlying Double values. 
        return m_value.CompareTo(other.m_value);
    }

    // Define the is greater than operator.
    public static bool operator >  (Mark operand1, Mark operand2)
    {
       return operand1.CompareTo(operand2) == 1;
    }
    
    // Define the is less than operator.
    public static bool operator <  (Mark operand1, Mark operand2)
    {
       return operand1.CompareTo(operand2) == -1;
    }

    // Define the is greater than or equal to operator.
    public static bool operator >=  (Mark operand1, Mark operand2)
    {
       return operand1.CompareTo(operand2) >= 0;
    }
    
    // Define the is less than or equal to operator.
    public static bool operator <=  (Mark operand1, Mark operand2)
    {
       return operand1.CompareTo(operand2) <= 0;
    }

    // The underlying Mark value.
    protected double m_value = 0.0;

    public double Mark_val    
    {
        get
        {
            return m_value;
        }
        set
        {
            if (value < 0.0)
            {
                throw new ArgumentException("Mark cannot be less than zero.");
            }
            else
            {
                m_value = value;
            }
        }
    }

}
