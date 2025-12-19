/*1 1 1 1 1
 2 2 2 2
3 3 3
4 4
5*/
using System;

namespace forloop9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Forloop 8");

            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j <= 5; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
