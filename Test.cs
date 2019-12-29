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
            Console.WriteLine("Pytagoras' constant as a float: " + Consts.PytagorasAsFloat);
            Console.WriteLine("Pytagoras' constant as a decimal: " + Consts.PytagorasAsDecimal);
            Console.WriteLine("Pytagoras' constant as a double: " + Consts.PytagorasAsDouble);

            //Print out infinity
            Console.WriteLine("Positive Infinity: " + Infinity.posInfinity);
            Console.WriteLine("Negative Infinity: " + Infinity.negInfinity);

            //Instances for the greek alphabet
            Console.WriteLine(Greek.iota);
            Console.WriteLine(Greek.zeta);
            Console.WriteLine(Greek.delta);
            Console.WriteLine(Greek.alpha);

            //Counts factorial test
            int num = 5;
            Console.WriteLine("Factoriail of " + num + ": " + Algebra.Factorial(num));

            //IsEven
            Console.WriteLine("2 is " + Numeric.IsEven(2) + " as even.");
            Console.WriteLine("3 is " + Numeric.IsEven(3) + " as even.");

            //Abs
            Console.WriteLine("Abs of 3 = " + Numeric.Abs(3));
            Console.WriteLine("Abs of -15 = " + Numeric.Abs(-15));
            Console.WriteLine("Abs of -3011.34 = " + Numeric.Abs(-3011.34));

            //Stops the project
            Console.ReadKey();
        }
    }
}
