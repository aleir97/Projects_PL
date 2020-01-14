using System;

namespace EXERCISE_23_PG612{
    class Test{
        static void Main(string[] args){
            
            List<int> myList = new List<int>(4);

            myList.Add(1);
            myList.Add(2);
            myList.Add(5);
            myList.Add(4);

            Console.WriteLine(myList);
            myList.Rmv(1);
            Console.WriteLine(myList);

            myList.Add_by_Index(2, 8);
            Console.WriteLine(myList);
            
            Console.WriteLine(myList.GetValue(0));
            
            Console.WriteLine(myList.Find(x => x == 5));
            Console.WriteLine(myList.Find(x => x == 8));
            
            myList.Clear();
        }
    }
}



