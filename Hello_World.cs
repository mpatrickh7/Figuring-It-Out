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
        beginning:
            Console.WriteLine("Enter a number");

            int x = Convert.ToInt32(Console.ReadLine());

            if (x > 100)
            {
                Console.WriteLine("Your number is too high");
                goto beginning;
            }

                if (x % 10 == 0 && x != 0)
                {
                    Console.WriteLine("Your number is a multiple of 10");
                    goto beginning;
                }
                else if (x == 0)
                {
                    Console.WriteLine("You input zero");
                    goto beginning;
                }

                else if (x % 2 == 0)
                {
                    Console.WriteLine("Your number is even");
                    goto beginning;
                }

                else if (x % 2 == 1)
                {
                    Console.WriteLine("Your number is odd");
                    goto beginning;
                }
                else
                {
                    Console.WriteLine("Try again. Input a number");
                    goto beginning;
                }
            }
        }
    }
