using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hello_World
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Input an integer");
            int x = Convert.ToInt32(Console.ReadLine()); // This converts the string into an integer

            if (x <= 100)
            {

                if (x % 2 == 0) // checks if the integer is even
                {
                    if (x == 0) // checks if the integer is zero
                    {
                        Console.WriteLine("Zero"); // if the integer is 0 it will print out 'zero' to the console
                    }

                    else
                    {
                        if (x % 10 == 0) // checks if the integer is a multiple of 10
                        {
                            Console.WriteLine("Multiple of 10"); // if the integer is a multiple of 10 it will print 'Multiple of 10' to the console
                        }

                        else
                        {
                            Console.WriteLine("Even Steven");

                        }
                    }

                }
                else
                {
                    Console.WriteLine("What an odd number");
                }
            }
            else
            {
                Console.WriteLine("TOO HIGH!");
            }
        }
    }
}

