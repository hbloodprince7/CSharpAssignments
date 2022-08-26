using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo2
{
    internal class Merge
    {
        public static void Main()
        {
            int n;
            int m;

            Console.WriteLine("Enter the first array size ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second array size ");
            m = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the first array value");
            int[] num1 = new int[n];
            int[] num2 = new int[m];
            int[] num3 = new int[num1.Length + num2.Length];


            for (int i = 0; i < n; i++)
            {
                num1[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Enter the second array value");
            for (int i = 0; i < m; i++)
            {
                num2[i] = int.Parse(Console.ReadLine());

            }
            Array.Copy(num1, 0, num3, 0, num1.Length);
            Array.Copy(num2, 0, num3, num1.Length, num2.Length);

            Console.WriteLine("Array after merging and sorting");
            foreach (int value in num3)
            {
                Console.WriteLine(value);

            }
        }
    }
}
