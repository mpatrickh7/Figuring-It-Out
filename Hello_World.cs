﻿using System;
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
            int x = Convert.ToInt32(Console.ReadLine());

            if (x <= 100)
            {

                if (x % 2 == 0)
                {
                    if (x == 0)
                    {
                        Console.WriteLine("Zero");
                    }

                    else
                    {
                        if (x % 10 == 0)
                        {
                            Console.WriteLine("Multiple of 10");
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

