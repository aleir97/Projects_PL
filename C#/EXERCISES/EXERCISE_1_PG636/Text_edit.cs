using System;
using System.IO;
using System.Text;
using System.IO.MemoryMappedFiles;

namespace EXERCISE_1_PG636
{
    class Text_edit
    {
        static void odd_lines()
        {
            int i = 0;
            var path = @"./thermopylae.txt";
            var path2 = @"./lodz.txt";

            string[] lines = File.ReadAllLines(path, Encoding.UTF8);
            string[] lines2 = File.ReadAllLines(path2, Encoding.UTF8);

            //Print the odd lines (EXERCISE: 1)

            for (i = 0; i < lines.Length; i++)
                if (i % 2 != 0)
                    Console.WriteLine(lines[i]);
        }

        static void merge_txt_files()
        {
            var path = @"./thermopylae.txt";
            var path2 = @"./lodz.txt";
            string[] lines = File.ReadAllLines(path, Encoding.UTF8);
            string[] lines2 = File.ReadAllLines(path2, Encoding.UTF8);

            //Merge 2 text files (EXERCISE: 2)
            string[] merge = new string[lines.Length + lines2.Length];
            Array.Copy(lines, merge, lines.Length);
            Array.Copy(lines2, 0, merge, lines.Length, lines2.Length);



            foreach (string line in merge)
                Console.WriteLine(line);
        }

        static void n_each_line()
        {
            int i = 0;
            string aux = "";
            var path = @"./thermopylae.txt";
            var path2 = @"./lodz.txt";

            string[] lines = File.ReadAllLines(path, Encoding.UTF8);
            string[] lines2 = File.ReadAllLines(path2, Encoding.UTF8);

            //Add the number of each line (EXERCISE: 3)
            for (i = 0; i < lines2.Length; i++)
            {
                aux = (i + 1) + " ";

                aux += lines2[i];
                lines2[i] = aux;
            }

            foreach (string line in lines2)
                Console.WriteLine(line);
        }

        static void cmp_txt_files()
        {
            int i = 0, min_length, match = 0, unmatch = 0;
            var path = @"./thermopylae.txt";
            var path2 = @"./lodz.txt";

            string[] lines = File.ReadAllLines(path, Encoding.UTF8);
            string[] lines2 = File.ReadAllLines(path2, Encoding.UTF8);


            //Compare 2 text files (EXERCISE: 4)
            min_length = Math.Min(lines.Length, lines2.Length);


            for (i = 0; i < min_length; i++)
                if (string.Compare(lines[i], lines2[i]) == 0)
                {
                    match++;
                }
                else
                    unmatch++;

            Console.WriteLine("EQUAL LINES: {0} \nDIFFERENT LINES: {1}", match, unmatch);
        }

        static void sub_mtx_max_sum()
        {
            var path = @"./matrix.txt";
            int[,] matrix, sub_2_2;
            int N, i, j, w, rst, cont, rowStart, rowEnd, colStart, colEnd, n_subMatrix;

            string[] fl_matrix = File.ReadAllLines(path, Encoding.UTF8);

            if (Int32.TryParse(fl_matrix[0].Trim(), out N) == true)
            {
                matrix = new int[N, N];

                for (i = 0; i < N; i++)
                {
                    for (j = 0; j < N; j++)
                    {
                        matrix[i, j] = Convert.ToInt32(Char.GetNumericValue(fl_matrix[i + 1], j));
                    }
                }

                rst = 0;
                cont = 0;

                rowStart = 0;
                rowEnd = rowStart + 2;

                colStart = 0;
                colEnd = colStart + 2;

                n_subMatrix = Convert.ToInt32(Math.Pow(Convert.ToDouble(N), 2.0)) / 4;

                for (i = 0; i < n_subMatrix; i++)
                {
                    sub_2_2 = ExtractSubMatrix(matrix, rowStart, rowEnd, colStart, colEnd);

                    for (w = 0; w < 2; w++)
                    {
                        for (j = 0; j < 2; j++)
                        {
                            cont += sub_2_2[w, j];
                        }
                    }

                    //Controls which sum of the elem in subMatrix is the biggest
                    if (i == 0)
                        rst = cont;
                    else
                        rst = Math.Max(rst, cont);

                    //Controls the iterance between submatrix
                    colStart += 2;
                    colEnd = colStart + 2;

                    if (colEnd > N)
                    {
                        colStart = 0;
                        colEnd = colStart + 2;

                        rowStart += 2;
                        rowEnd = rowStart + 2;
                    }

                    cont = 0;
                }

                Console.WriteLine(rst);

            }
            else
                Console.WriteLine("I cant take the first line");
        }

        private static int[,] ExtractSubMatrix(
            int[,] matrix,
            int rowStart, int rowEnd,
            int colStart, int colEnd
            )
        {
            int i, x, y, j;

            var sizeRow = rowEnd - rowStart;
            var sizeCol = colEnd - colStart;

            int[,] result = new int[sizeRow, sizeCol];

            for (i = rowStart; i < rowEnd; i++)
            {
                for (j = colStart; j < colEnd; j++)
                {

                    x = i - rowStart;
                    y = j - colStart;

                    result[x, y] = matrix[i, j];
                }
            }

            return result;
        }

        public static void name_aph_ord()
        {
            var path = @"./names.txt";

            string[] names = File.ReadAllLines(path, Encoding.UTF8);

            Array.Sort<String>(names, (x, y) => String.Compare(x, y));

            foreach (string name in names)
                Console.WriteLine(name);


            File.WriteAllLines(@"./sorted_names.txt", names);

        }

        public static void EX_7_8(){
            Stream mmStream;
            StreamReader sr;
            StreamWriter sw;
            string line;

            using (var mappedFile1 = MemoryMappedFile.CreateFromFile(@"./replace.txt"))
            {
                using (mmStream = mappedFile1.CreateViewStream())
                {
                    using (sr = new StreamReader(mmStream, ASCIIEncoding.ASCII))
                    {
                        using (sw = File.AppendText(@"./replace2.txt"))
                        {
                            while (!sr.EndOfStream)
                            {

                                line = sr.ReadLine();
                                line = line.Replace("FINISH", "START");
                                
                                sw.WriteLine(line);
                                    
                            }
                            sw.Close();
                            sr.Close();
                        }
                    }
                }
            }

            File.Delete(@"./replace.txt");
            File.Move("./replace2.txt", "./replace.txt");
        }

        static void Main(string[] args)
        {
            //odd_lines();
            //merge_txt_files();
            //n_each_line();
            //cmp_txt_files();
            //sub_mtx_max_sum();
            //name_aph_ord();
            EX_7_8();


        }
    }
}
