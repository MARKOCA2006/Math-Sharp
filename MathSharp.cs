namespace MathSharp
{
    using System;

    namespace Constants
    {
        public static class Consts
        {
            public static float PiAsFloat = (float)3.141592653589793238462643383279502884197169399375105820974944592307816406;
            public static double PiAsDouble = (double)3.141592653589793238462643383279502884197169399375105820974944592307816406;
            public static decimal PiAsDecimal = (decimal)3.141592653589793238462643383279502884197169399375105820974944592307816406;

            public static float eAsFloat = (float)2.7182818284590452353602874713526624977572470;
            public static double eAsDouble = (double)2.7182818284590452353602874713526624977572470;
            public static decimal eAsDecimal = (decimal)2.7182818284590452353602874713526624977572470;

            public static float PythagorasAsFloat = (float)1.41421356237309504880168872420969807856967187537694807317667973799;
            public static double PythagorasAsDouble = (double)1.41421356237309504880168872420969807856967187537694807317667973799;
            public static decimal PythagorasAsDecimal = (decimal)1.41421356237309504880168872420969807856967187537694807317667973799;
        }
    }

    namespace Infinity
    {
        public static class Infinity
        {
            public static double posInfinity = double.PositiveInfinity;
            public static double negInfinity = double.NegativeInfinity;
        }
    }


    public class Numeric
    {
        public static bool IsEven(int num)
        {
            if (num % 2 == 0)
                return true;
            else
                return false;
        }

        public static double Abs(double num)
        {
            if (num < 0)
                return -num;
            else
                return num;
        }

        public static bool IsPrime(int num)
        {
            if (num == 2 || num == 3 || num == 5 || num == 7)
                return true;
            else if (num % 2 == 0)
                return false;
            else if (num % 3 == 0)
                return false;
            else if (num % 5 == 0)
                return false;
            else if (num % 7 == 0)
                return false;
            else
                return true;
        }

        public static int decToBin(int num)
        {  
            int a = 0;
            int b = 0;
            while (num != 0)
            {
                int temp = num % 2;
                int c = (int)Math.Pow(10, b);
                a += temp * c;
                num /= 2;  
                b++;
            }
            return a;
        }
    }


    public class Algebra
    {
        public static int Factorial(int num)
        {
            if (num <= 0)
                return 1;
            return Factorial(num - 1) * num;
        }

        public static double Pow(double a, double n)
        {
            return Math.Pow(a, n);
        }

        public static double Root(double a, int n)
        {
            return Pow(a, (double)1 / n);
        }
    }

    namespace Geometry
    {
        using MathSharp.Constants;
        public class Geometry
        {

            public static double Rad(double num)
            {
                return num * (180 / Consts.PiAsDouble);
            }

            public static double PythagorasTheory(double a, double b)
            {
                double temp = Algebra.Pow(a, 2) + Algebra.Pow(b, 2);
                return Algebra.Root(temp, 2);
            }
        }
    }
}
