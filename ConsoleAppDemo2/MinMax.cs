using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo2
{
    internal class MinMax
    {
        public static void Main()
        {
            int n;

            Console.WriteLine("Enter the number of elements you want to store");
            n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            Console.WriteLine("Enter the array values");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Max element is {numbers.Max()} ");
            Console.WriteLine($"Min element is {numbers.Min()} ");
        }
    }
}
