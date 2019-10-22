using System;

namespace C_{
    
    class EXERCISES{
    
        static void IT_FACTORIAL(int n){
            int i;
            long cont= 1;

            for(i= 1; i<= n; i++){
                cont = i * cont;
               
            }
            Console.WriteLine(cont);
        }

        static long REC_FACTORIAL(int n){ 
            long cont= n;
            
            if (n == 1 || n == 0)
                return 1;
            else 
                cont= cont* REC_FACTORIAL(n-1);
                
            return cont;
        }

        static long FACTN_DIV_FACTK (int n, int k){
            long res;

            res= REC_FACTORIAL(n)/ REC_FACTORIAL(k);          

            return res;
        }
        
        static long FACTNxFACTK_DIV_FACTNminusK(int n, int k){
            long res;

            res= (REC_FACTORIAL(n)* REC_FACTORIAL(k))/ REC_FACTORIAL(n-k);   

            return res;
        }
        
        static void Main(string[] args){
            string val;
            int n, menu =1, k;
            DateTime start;
            TimeSpan timeItTook;

            while (menu != 0){
                Console.WriteLine("CHOOSE THE EXCERCISE: 5, 6 OR 7 (FOR EXIT ENTER 0)");
                val= Console.ReadLine(); 
                menu= Convert.ToInt32(val);
                
                if (menu == 5){
                    Console.WriteLine("Calculus of Factorial");
                    Console.Write("Enter integer: ");
                    n = Convert.ToInt32(Console.ReadLine());
        
                    Console.WriteLine("--Iterative version--");
                    start = DateTime.Now;
                    IT_FACTORIAL(n);
                    timeItTook = DateTime.Now - start;
                    Console.WriteLine("Iterative vesion took: " + timeItTook);
            
                    Console.WriteLine("\n--Recursive version--");
                    start = DateTime.Now;
                    Console.Write("{0}\n",REC_FACTORIAL(n));
                    timeItTook = DateTime.Now - start;
                    Console.WriteLine("Recursive vesion took: " + timeItTook);            
                
                }else if (menu == 6 || menu== 7){
                    Console.Write("Enter integer N: ");    
                    val= Console.ReadLine(); 
                    n= Convert.ToInt32(val);
                    
                    Console.Write("Enter integer K: ");    
                    val= Console.ReadLine(); 
                    k= Convert.ToInt32(val);

                    if(menu== 6)
                        Console.WriteLine("RESULT OF CALCULATION: {0}",FACTN_DIV_FACTK(n, k));
                    else    
                        Console.WriteLine("RESULT OF CALCULATION: {0}",FACTNxFACTK_DIV_FACTNminusK(n, k));
    
                }else   
                    continue;
            }
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
