using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LR_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create.Sum();*/
            Create create = new Create();
            create.Sum(); 
            Console.ReadKey();

        }
    }
    class Create
    {

        public /*static*/ void Sum()
        {
            Console.WriteLine("Введите количество элементов: ");
            int N = Convert.ToInt32(Console.ReadLine()); //количество элементов
            int[] mas = new int[N]; //массив значений
            int Result = 0;
            for (int i = 0; i<N; i++ )
            {
                Console.WriteLine("Введите значение а: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Result +=x * x;
                mas[i] = Result;
            }

            for (int i=0; i<N;i++)
            {
                Console.WriteLine($"Значения поледовательности = {mas[i]}");
            }
           

        }
    }
}
