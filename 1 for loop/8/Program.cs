/* 5 5 5 5 5
 4 4 4 4
3 3 3
2 2
1*/
using System;

namespace forloop8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Forloop 8");

            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}