using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo2
{
    internal class Negative
    {
        public static void Main()
        {
            int n;
            Console.WriteLine("Enter the size of an array");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the array elements");
            int[] negav = new int[n];

            for (int i = 0; i < n; i++)
            {
                negav[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < n; i++)
            {
                if (negav[i] < 0)
                {
                    Console.WriteLine($"These are the negative number {negav[i]}");
                }
            }
        }
    }
}
