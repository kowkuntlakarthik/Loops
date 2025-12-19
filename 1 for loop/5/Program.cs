/*1

2 2

3 3 3

4 4 4 4

5 5 5 5 5*/

using System;

namespace forloop5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("forloop 5");
            for ( int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= i ; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}