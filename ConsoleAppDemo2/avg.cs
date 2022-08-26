using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo2
{
    internal class avg
    {
        public class AvgArray
        {
            public static void Main()
            {
                double sum = 0, avg = 0;
                double[] numbers = { 10, 20, 50, 40 };
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
                avg = sum / numbers.Length;
                Console.WriteLine($"The Sum is :{sum}");
                Console.WriteLine($"The Average is :{avg}");
            }
        }
    }
}
