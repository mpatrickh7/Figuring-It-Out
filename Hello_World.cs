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
            int variable = 1;

            while (variable <= 10) 
            {
                Console.WriteLine("counter: {0}", variable);
                variable++;
            }

            variable = 1;

            do
            {
                Console.WriteLine("counter: {0}", variable);
                variable++;
            }
            while (variable <= 10);

            for (variable = 1; variable <= 10; variable++)
            {
                Console.WriteLine("counter: {0}", variable);
            }
        }
    }
}
