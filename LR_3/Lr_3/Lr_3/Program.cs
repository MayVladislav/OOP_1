using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lr_3
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            int N = Convert.ToInt32(Console.ReadLine()); // кол-во  строк  
            int M = Convert.ToInt32(Console.ReadLine()); // кол-во столбцов

            int[,] trans = new int[N, M];  // массив с транспонированной матрицей
            int[,] mas = new int[N, M];
            double[] zn = new double[M]; // массив для хранения ср арифметического всех строк

            //Вывод исходной матрицы
            Console.WriteLine("Вывод исходной матрицы: ");
            for (int i = 0; i < N; i++)
            {
                string str_all = Console.ReadLine();
                string[] str_elem = str_all.Split(' ');
                for (int j = 0; j < M; j++)
                {
                    mas[i, j] = Convert.ToInt32(str_elem[j]);
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }

            //транспонируем исходную матрицу
           /* Console.WriteLine("Вывод транс матрицы: ");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    trans[i, j] = mas[j, i];
                    Console.Write(trans[i, j] + " ");
                }
                Console.WriteLine(); 
            }*/
            // подсчет ср арифмет элементов для каждого столбца
            Console.WriteLine("Вывод ср арифметического четных элементов для каждой строки : ");
            float max = 0;
            float sa = 0;
            int k = 0;
            for (int i = 0; i < N; i++)
            {
                max = 0;
                for (int j = 0; j < M; j++)
                {
                    max += mas[i, j];
                    zn[i] = max / M;
                }
                //Console.WriteLine(zn[i]);
                Console.WriteLine(max);
            }

            /* 
             for (int i =0; i<M; i++)
             {
                 Console.WriteLine(zn[i]);
             }
            */
            Console.WriteLine("Вывод измененной матрицы: ");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (mas[i, j] %2 == 0)
                    {
                        Console.Write(zn[i] + " ");
                    }
                    else
                    {
                        Console.Write(mas[i, j]+ " ");
                    }

                }
                Console.WriteLine();
            }

            Console.SetOut(save_out);
            new_out.Close();
            Console.SetIn(save_in);
            new_in.Close();

            Console.ReadKey();

        }
    }
}
