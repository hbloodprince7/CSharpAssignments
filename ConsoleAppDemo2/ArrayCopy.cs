using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo2
{
    internal class ArrayCopy
    {
        public static void Main()
        {
            int n;
            Console.WriteLine("Enter the size of an array");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the array elements");

            int[] array1 = new int[20];
            int[] array2 = new int[20];

            for (int i = 0; i < n; i++)

            {
                array1[i] = int.Parse(Console.ReadLine());


            }

            for (int i = 0; i < n; i++)

            {
                array2[i] = array1[i];


            }
            Console.WriteLine("Elements of first array are:  ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{array1[i]} \n");
            }

            Console.WriteLine("Elements of  second array are:  ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{array2[i]} \n");
            }
        }
    }
}
