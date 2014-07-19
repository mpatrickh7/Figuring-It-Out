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
            int originalNumber = 22;
            int result;
            int nextNumber = 22;
            int result2;

            //int nextNumber = originalNumber++;

            result = ++originalNumber; // This is taking 1, represented by '++,' and adding it to 22, represented by originalNumber. 1 + 22 = 23
            result2 = nextNumber++; // result2 automatically equals the value of nextNumber which is 22. nextNumber is saying "I'm 22... now add 1 to me." Which is 23

            Console.WriteLine("Prefix: ++originalNumber = {0}, result = {1}", originalNumber, result);
            Console.WriteLine("Postfix: nextNumber++ = {0}, result2 = {1}", nextNumber, result2);
        }
    }
}
