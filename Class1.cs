using System;
namespace CSC205Week06
{
	public class Rational
	{
		int numerator;
		int denominator;

		public Rational()
		{
			int numerator = 0;
			int denominator = 1;
		}
		public Rational(int numerator, int denominator)
        {
			this.numerator = numerator;
			this.denominator = denominator;
        }
		public static void WriteRational(Rational numerator, Rational denominator)
        {
            global::System.Console.WriteLine(numerator + "/" + denominator);

        }








	}
}