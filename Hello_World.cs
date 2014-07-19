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
            const double radius = 5;
            const float Pi = 3.14159f;
            double surfaceArea = (4 * Pi * radius) * 2;
            double volume = (4 / 3) * (Pi * radius) * 3;
            double maxValue = surfaceArea > volume ? surfaceArea : volume;
            Console.WriteLine("surfaceArea: {0}, \nvolume: {1}, \nmaxValue: {2}", surfaceArea, volume, maxValue);
            Console.WriteLine("The greater of these is {0}", maxValue);
            
        }
    }
}
