/*5 4 3 2 1
 5 4 3 2
 5 4 3
5 4  
5*/
using System;

namespace forloop7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Forloop 6");
            
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(j +" ");
                }
                Console.WriteLine();
            }
        }
    }
}