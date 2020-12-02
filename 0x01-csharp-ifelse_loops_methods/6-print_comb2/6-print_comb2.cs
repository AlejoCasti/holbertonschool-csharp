using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++) {
                if (i % 10 > i / 10) {
                    Console.Write(i != 89 ? "{0:00}, " : "{0:00}\n", i);
                }
            }
        }
    }
}
