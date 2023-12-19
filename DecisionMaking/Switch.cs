using System;

namespace Demo
{
    class Program
    {
        static void Main(string[]args)
        {
            int i=4;
            switch(i)
            {
                case 1:Console.WriteLine("The value of i is 1");
                    break;

                case 2:Console.WriteLine("The value of i is 2");
                    break;

                case 3:Console.WriteLine("The value of i is 3");
                    break;

                case 4:Console.WriteLine("The value of i is 4");
                    break;

                default:Console.WriteLine("The value of i is unknown");
                    break;
            }

            Console.Read();
        }
    }
}