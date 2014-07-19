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
            const int minimum = 100;
            const int maximum = 300;
            const int Abby = 135;
            const int Bob = 175;
            const int Charlie = 55;
            const int Dawn = 45;
            


            Console.WriteLine("Abby and Bob can ride? {0}", (Abby + Bob > minimum) && (Abby + Bob <= maximum));
            Console.WriteLine("Bob and Charlie can ride? {0}", (Bob + Charlie > minimum) && (Bob + Charlie <= maximum));
            Console.WriteLine("Charlie and Dawn can ride? {0}", (Charlie + Dawn > minimum) & (Charlie + Dawn <= maximum));
        }
    }
}
