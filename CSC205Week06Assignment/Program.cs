using System;
namespace CSC205Week06
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Rational r1 = new Rational();
            r1.numerator = -7;
            r1.denominator = 1;
            Rational r2 = new Rational(445,12);

            //r1.WriteRational(r1);
            //r2.WriteRational(r2);
            //Console.WriteLine();
            //r1.Negate(r1);
            //r2.Negate(r2);
            //Console.WriteLine();
            //r1.Invert(r1);
            //r2.Invert(r2);
            //Console.WriteLine();
            Console.WriteLine(Rational.ToDouble(r1));
            Console.WriteLine(r2.ToDouble(r2));
        
        }
    }
}