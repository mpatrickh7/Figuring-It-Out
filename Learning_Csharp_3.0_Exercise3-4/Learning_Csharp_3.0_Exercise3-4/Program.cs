using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Learning_Csharp_3._0_Exercise3_4
{
    class Program
    {
        enum Months : int
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12,
        }
        static void Main(string[] args)
        {
            // You've to put the variable type in before the enumeration name
            Console.WriteLine("June is month number {0}.", (int) Months.June);
            Console.ReadLine();
        }
    }
}
