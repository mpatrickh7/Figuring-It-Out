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
            int myInt = 42;
            float daFloat = 98.6f;
            double doubleTrouble = 12345.6789;
            char zzzzz = 'Z';
            string myString = "The quick brown fox jumped over the lazy dogs.\n";
            Console.WriteLine(myInt);
            Console.WriteLine(daFloat);
            Console.WriteLine(doubleTrouble);
            Console.WriteLine(zzzzz);
            Console.WriteLine(myString);

            myInt = 25;
            daFloat = 100.3f;
            doubleTrouble = 98765.4321;
            zzzzz = 'M';
            myString = "A quick movement of the enemy will jeopardize six gun boats";
            Console.WriteLine(myInt);
            Console.WriteLine(daFloat);
            Console.WriteLine(doubleTrouble);
            Console.WriteLine(zzzzz);
            Console.WriteLine(myString);
        }
    }
}
