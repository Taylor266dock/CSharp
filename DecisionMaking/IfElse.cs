using System;

namespace Demo
{
    class Program
    {
        static void Main(string[]args)
        {
            int i = 4;

            if(i==3)
                Console.WriteLine("The value of i is " + i);
            else
                Console.WriteLine("The value of i is not equal to 3.");
            Console.Read();
        }
    }
}