using System.Runtime.CompilerServices;

namespace ConsoleAppDemo2
{
    public class A2
    {
        public static int SmallestNum(int a, int b)
        {
            if (a > b)
            {
                return b;
            }
            else
            {
                return a;
            }

        }
        public static void main()
        {
            int a, b;
            Console.WriteLine("Enter the numbers");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

        }

    }

}
