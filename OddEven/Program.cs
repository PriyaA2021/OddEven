using System;

namespace OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter a number");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("The entered number " + a + " is even");
            }
            else
            {
                Console.WriteLine("The entered number " + a + " is odd");
            }
        }
    }
}
