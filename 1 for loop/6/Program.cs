/* 5
 4 4
3 3 3
2 2 2 2
1 1 1 1 1*/
using System;

namespace forloop6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Forloop 6");
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}