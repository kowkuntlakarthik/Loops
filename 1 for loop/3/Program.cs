/*5 4 3 2 1

4 3 2 1

3 2 1

2 1

1*/

using System;

namespace forloop3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For loop pattern");
            for (int i = 5; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
