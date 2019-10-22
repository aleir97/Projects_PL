//ex. Ch6_ex5
using System;

class  Fibonacci {
    
  static void fibo (int number) 
  {
      long f;
      long a = 1;
      long b = 1;
      
      Console.Write(a + " ");
      Console.Write(b + " ");
          
      for(int i = 3; i <= number; i++)
      {
          f = a + b;
          a = b;
          b = f;
          Console.Write(f + " ");
      } 
  } // fibo
  
  static long fibo2 (int n)
  {
      if (n<3) return 1;
      return fibo2(n-1) + fibo2(n-2);
  } //fibo2
  
  
  static void Main() {
      string val;
      Console.Write("Enter integer: ");
      val = Console.ReadLine();
      
      int N = Convert.ToInt32(val);
      Console.WriteLine("Your input: {0}",N);
      
      // calling the function fibo
      
      Console.WriteLine("--Iterative version--");
      DateTime start = DateTime.Now;
      fibo(N);
      TimeSpan timeItTook = DateTime.Now - start;
      Console.WriteLine("Iterative vesion took: " + timeItTook);
      
      Console.WriteLine("--Recursive version--");
      start = DateTime.Now;
      for(int i = 1 ; i <= N; i++)
      {
        Console.Write(fibo2(i) + " ");
      }
      timeItTook = DateTime.Now - start;
      Console.WriteLine("Recursive vesion took: " + timeItTook);
  }
}



