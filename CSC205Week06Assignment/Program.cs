using System;
namespace CSC205Week06
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Rational r1 = new Rational();
            r1.numerator = 20;
            r1.denominator = 4;
            Rational r2 = new Rational(10 , 8);

            //r1.WriteRational(r1); // Testing method
            //r2.WriteRational(r2);
            //Console.WriteLine();
            //r1.Negate(r1);
            //r2.Negate(r2);
            //Console.WriteLine();
            //r1.Invert(r1); // Testing Method
            //r2.Invert(r2);
            //Console.WriteLine();
            //Console.WriteLine(Rational.ToDouble(r1)); // Convert the rational to double 
            //Console.WriteLine(Rational.ToDouble(r2));
            //Console.WriteLine();
            //r1.WriteRational(r1); // Confirming the methods have not changed the original Object
            //r2.WriteRational(r2);
            //Console.WriteLine();
            Console.WriteLine(Rational.Reduce(r1));
            Console.WriteLine(Rational.Reduce(r2));
            Console.WriteLine();
            Rational.WriteRational(Rational.Add(r1, r2)); // In debugger it has the correct value, but it doesn't print it. 
        }
    }
}

