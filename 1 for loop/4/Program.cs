/*1

1 2

1 2 3

1 2 3 4

1 2 3 4 5 */
using System;

namespace forloop4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Forloop 4");
            for(int i = 1; i <=5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}