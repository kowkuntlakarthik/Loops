/*5
 5 4
5 4 3
5 4 3 2
5 4 3 2 1*/
using System;

namespace forloop10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Forloop 8");

            for (int i = 5; i >= 1; i--)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}