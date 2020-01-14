using System;
using System.IO;
using System.Text;

namespace EXERCISE_1_PG636{
    class Text_edit{
        static void Main(string[] args){
            int i = 0, min_length, match = 0, unmatch = 0;
            string aux ="";

            var path = @"./thermopylae.txt";
            var path2 = @"./lodz.txt";

            string[] lines = File.ReadAllLines(path, Encoding.UTF8);
            string[] lines2 = File.ReadAllLines(path2, Encoding.UTF8);

            /*
            //Print the odd lines (EXERCISE: 1)
            
            for (i = 0; i < lines.Length; i++)
                if (i % 2 != 0)
                    Console.WriteLine(lines[i]);
            
            
            
            //Merge 2 text files (EXERCISE: 2)
            string[] merge = new string[lines.Length + lines2.Length];
            Array.Copy(lines, merge, lines.Length);
            Array.Copy(lines2, 0, merge, lines.Length, lines2.Length);
            

            
            foreach(string line in merge )
                Console.WriteLine(line);
            
            
            //Add the number of each line (EXERCISE: 3)
            for(i = 0; i < lines2.Length; i++){
                aux = (i+1) + " ";
                
                aux += lines2[i];
                lines2[i] = aux;
            }
            
            
            foreach(string line in lines2 )
                Console.WriteLine(line);
            */
            


          
            //Compare 2 text files (EXERCISE: 4)
            min_length = Math.Min(lines.Length, lines2.Length);
            

            for(i = 0; i < min_length; i++)
                if (string.Compare(lines[i], lines2[i]) == 0 ){
                    match ++;
                }else
                    unmatch++;
            
            Console.WriteLine("EQUAL LINES: {0} \nDIFFERENT LINES: {1}", match, unmatch);
            
    
            

        }
    }
}
