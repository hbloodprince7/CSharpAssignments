using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo2
{
    internal class Second
    {
        public static void Main()
        {
            int n;
            Console.WriteLine("Enter the size of n");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the array values");
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array);
            Array.Reverse(array);
            Console.WriteLine($"Second Highest Value In Array {array[1]}");

            foreach (var result in array)
            {
                Console.Write($"{result} \n");
            }
        }
    }
}
