namespace MathSharp
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

    
    public static class Infinity
    {
        public static double posInfinity = double.PositiveInfinity;
        public static double negInfinity = double.NegativeInfinity;
    }


    public enum Greek
    {
        alpha, // 0
        beta, // 1
        gamma, // 2
        delta, // 3
        epsilon, // 4
        zeta, // 5
        eta, // 6
        theta, // 7
        iota, // 8
        kappa, // 9
        lambda,  // 10
        mu, // 11
        nu, // 12
        xi, // 13
        omicron, // 14
        pi, // 15
        rho, // 16
        sigma, // 17
        tau, // 18
        upsilon, // 19
        phi, // 20
        chi, // 21
        psi, // 22
        omega // 23
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
    }


    public class Algebra
    {
        public static int Factorial(int num)
        {
            if (num <= 0)
                return 1;
            return Factorial(num - 1) * num;
        }
    }
}
