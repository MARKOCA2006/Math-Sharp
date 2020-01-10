using MathSharp.Infinity;
using MathSharp.Constants;
using MathSharp;
using MathSharp.Geometry;
using System;

namespace MathSharpTest
{
    class Test
    {
        static void Main(string[] args)
        {
            //Print out PI
            Console.WriteLine("Pi as a float: " + Consts.PiAsFloat);
            Console.WriteLine("Pi as a decimal: " + Consts.PiAsDecimal);
            Console.WriteLine("Pi as a double: " + Consts.PiAsDouble);

            //Print out E
            Console.WriteLine("E as a float: " + Consts.eAsFloat);
            Console.WriteLine("E as a decimal: " + Consts.eAsDecimal);
            Console.WriteLine("E as a double: " + Consts.eAsDouble);

            //Print out Pytagoras' constant
            Console.WriteLine("Pytagoras' constant as a float: " + Consts.PythagorasAsFloat);
            Console.WriteLine("Pytagoras' constant as a decimal: " + Consts.PythagorasAsDecimal);
            Console.WriteLine("Pytagoras' constant as a double: " + Consts.PythagorasAsDouble);

            //Print out infinity
            Console.WriteLine("Positive Infinity: " + Infinity.posInfinity);
            Console.WriteLine("Negative Infinity: " + Infinity.negInfinity);

            //Counts factorial test
            Console.WriteLine("Factoriail of 5: " + Algebra.Factorial(5));

            //IsEven
            Console.WriteLine("2 is " + Numeric.IsEven(2) + " as even.");
            Console.WriteLine("3 is " + Numeric.IsEven(3) + " as even.");

            //Abs
            Console.WriteLine("Abs of 3 = " + Numeric.Abs(3));
            Console.WriteLine("Abs of -15 = " + Numeric.Abs(-15));
            Console.WriteLine("Abs of -3011.34 = " + Numeric.Abs(-3011.34));

            //IsPrime
            Console.WriteLine("2 is " + Numeric.IsPrime(2) + " as prime.");
            Console.WriteLine("2 is " + Numeric.IsPrime(4) + " as prime.");
            Console.WriteLine("2 is " + Numeric.IsPrime(1999) + " as prime.");
            Console.WriteLine("2 is " + Numeric.IsPrime(315) + " as prime.");

            //decToBin
            Console.WriteLine("8 in decimal is: " + Numeric.decToBin(8));
            Console.WriteLine("100 in decimal is: " + Numeric.decToBin(100));
            Console.WriteLine("20 in decimal is: " + Numeric.decToBin(20));
            Console.WriteLine("0 in decimal is: " + Numeric.decToBin(0));

            //Pow
            Console.WriteLine("5^3: " + Algebra.Pow(5, 3));
            Console.WriteLine("100^41: " + Algebra.Pow(100, 41));
            Console.WriteLine("5.9^3.45: " + Algebra.Pow(5.9, 3.45));

            //Root
            Console.WriteLine("Cube root of 8: " + Algebra.Root(8, 3));
            Console.WriteLine("5th root of 434: " + Algebra.Root(434, 5));
            Console.WriteLine("Cube root of 15: " + Algebra.Root(15, 3));

            //Rad
            Console.WriteLine("Rad of 2: " + Geometry.Rad(2));
            Console.WriteLine("Rad of 556: " + Geometry.Rad(556));
            Console.WriteLine("Rad of 41: " + Geometry.Rad(41));

            //Pythagoras Theory
            Console.WriteLine("If we apply Pythagoras' Theory to 5 and 6 we get: " + Geometry.PythagorasTheory(5, 6));

            //Stops the project
            Console.ReadKey();
        }
    }
}
