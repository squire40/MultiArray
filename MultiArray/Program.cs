using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer");
            var num = int.Parse(Console.ReadLine());

            int[,] arr = new int[num, 3];

            var value = 1;

            for (int i = 0; i < num; i++)
            {
                arr[i, 0] = value;
                arr[i, 1] = value * value;
                arr[i, 2] = value * value * value;
                value++;
            }

            Console.WriteLine($"\tNumber\tSquared\tCubed");
            Console.WriteLine($"\t======\t=======\t=====");

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("\t{0}\t{1}\t{2}", arr[i, 0], arr[i, 1], arr[i, 2]);
            }

            Console.WriteLine();

            Console.WriteLine();
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"\t{arr[i, 0]}\t{arr[i, 1]}\t{arr[i, 2]}");
            }

            Console.ReadKey();
        }
    }
}
