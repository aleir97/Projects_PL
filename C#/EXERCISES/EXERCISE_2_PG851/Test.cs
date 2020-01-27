using System;
using System.Collections.Generic;


namespace EXERCISE_2_PG851
{
    class Test
    {
        static void Test_wage_hour()
        {
            TimeSpan h_worked = new TimeSpan(20,2,0);
            Worker w0 = new Worker("Alejandro", "Iregui", 200.0, h_worked);

            Console.WriteLine("{0: 0.##}", w0.calculate_hourly_wage());
        }

        static void Test_srt_list()
        {
            SortedList<Mark, Student> students = new SortedList<Mark, Student>();
            
            Student s0 = new Student("Alejandro", "Iregui", 9.3);  
            students.Add(new Mark(s0.Mark), s0);  
            
            s0 = new Student("Hasan", "Arzy", 3.5);
            students.Add(new Mark(s0.Mark), s0);

            s0 = new Student("Ayperi", "Abd", 6.5);
            students.Add(new Mark(s0.Mark), s0);

            s0 = new Student("Marina", "Leon", 8);
            students.Add(new Mark(s0.Mark), s0);

            foreach( KeyValuePair<Mark, Student> kvp in students )
                Console.WriteLine("{0}: {1}", kvp.Value.FirstNm, kvp.Key.Mark_val); 
        }

        static void Main(string[] args)
        {
         //Test_wage_hour();
         Test_srt_list();
        }
    }
}
