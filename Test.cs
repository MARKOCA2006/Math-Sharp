using MathSharp;
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

            //Instances for the greek alphabet
            Console.WriteLine(Greek.iota);
            Console.WriteLine(Greek.zeta);
            Console.WriteLine(Greek.delta);
            Console.WriteLine(Greek.alpha);

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

            //Stops the project
            Console.ReadKey();
        }
    }
}
