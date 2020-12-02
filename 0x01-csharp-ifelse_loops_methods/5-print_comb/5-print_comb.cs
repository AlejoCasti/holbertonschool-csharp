using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 99; i++) {
                Console.Write(i != 99 ? "{0:00}, " : "{0:00}\n", i); 
            }
        }
    }
}
