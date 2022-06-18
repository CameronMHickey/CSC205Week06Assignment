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
		public static double ToDouble(Rational rational) // Convert the Rational to a Double 
		{
			Rational ToD = new Rational();
			double sum = (double)rational.numerator / (double)rational.denominator;

			return sum;

			// ToD.numerator = Convert.ToDouble(rational.numerator);  // Not really sure why it refuses to convert from int to double.
			// ToD.numerator = (double)rational.numerator; // Requires Cast but Cast is redundant. The fuck is wrong with this programming language?
		}
		public static long Reduce(Rational rational)
		{
			return GCD(rational.numerator, rational.denominator);
		}
		static long GCD(long n1, long n2)
		{
			if (n2 == 0)
			{
				return n1;
			}
			else
			{
				return GCD(n2, n1 % n2);
			}
		}
		public static Rational Add(Rational rational1, Rational rational2)
		{
			Rational Add = new Rational();
			int AddNum = rational1.numerator + rational2.numerator;
			int AddDen = rational1.denominator + rational2.denominator;

			long simptop = AddNum / GCD(AddNum, AddDen);
			long simpbot = AddDen / GCD(AddNum, AddDen);
			Add.numerator = (int)simptop;
			Add.denominator = (int)simpbot;
			
			return Add;
		}
	}
}		
	
