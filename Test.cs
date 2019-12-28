using MathSharp;
using System;

namespace MathSharpTest
{
    class Test
    {
        static void Main(string[] args)
        {
            //Print out PI
            Console.WriteLine("Pi as a float: " + Consts.Pi);
            Console.WriteLine("Pi as a decimal: " + Consts.PiAsDecimal);
            Console.WriteLine("Pi as a double: " + Consts.PiAsDouble);

            //Print out E
            Console.WriteLine("E as a float: " + Consts.e);
            Console.WriteLine("E as a decimal: " + Consts.eAsDecimal);
            Console.WriteLine("E as a double: " + Consts.eAsDouble);

            //Stops the project
            Console.ReadKey();
        }
    }
}