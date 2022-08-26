using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo2
{
    internal class Unique
    {
        public static void Main()


        {

            int[] items = { 91, 98, 135, 212, 237, 135, 92, 212, 93, 96 };
            int n = items.Length;

            Console.WriteLine("Unique array elements are: ");

            for (int i = 0; i < n; i++)
            {
                bool Same = false;
                for (int j = 0; j < i; j++)
                {
                    if (items[i] == items[j])
                    {
                        Same = true;
                        break;
                    }
                }

                if (!Same)
                {
                    Console.WriteLine(items[i]);

                }
            }
        }
    }
}
