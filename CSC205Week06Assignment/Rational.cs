namespace CSC205Week06
{
	public class Rational
	{
		public int numerator, denominator;
		public Rational() // Constructor
		{
			numerator = 0;
			denominator = 1;
		}
        public Rational(int numerator, int denominator) // Parametric Constructor
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        public void WriteRational(Rational rational) // Prints rational 
		{
			Console.WriteLine(this.numerator + "/" + this.denominator);
		}
		public void Negate(Rational rational) // Reverses sign of the Rational
		{
			int neg = this.numerator * -1;
            Console.WriteLine(neg + "/" + this.denominator);
		}
		public void Invert(Rational rational) // Prints Invert of the rational
		{
			Console.WriteLine(this.denominator + "/" + this.numerator);
		}
		public static Rational ToDouble(Rational rational)
		{
			Rational ToD = new Rational();
			double num = Convert.ToDouble(ToD.numerator);
			double denom = Convert.ToDouble(ToD.denominator);
			ToD.numerator = (int)num;
			ToD.denominator = (int)denom;
			return ToD;
		}
	}
}