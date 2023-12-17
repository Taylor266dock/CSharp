using System;
using System.Collections;

namespace Demo
{
    class Program
    {
        static void Main(string[]args)
        {
            int i = 1;

            if(i == 1){Console.WriteLine("The value is 1");}

            for(int j = 0; j < 5; j++)
                Console.WriteLine("The value of j is " + j);

            Console.Read();
        }
    }
}