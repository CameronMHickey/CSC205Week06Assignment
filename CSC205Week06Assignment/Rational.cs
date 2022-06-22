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
		public static void WriteRational(Rational rational) // Prints rational 
		{
			Console.WriteLine(rational.numerator + "/" + rational.denominator);
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
		}
		public static int Reduce(Rational rational)
		{
			return GCD(rational.numerator, rational.denominator);
		}
		static int GCD(int n1, int n2)
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
			int AddNum = (rational1.numerator * rational2.denominator ) + (rational2.numerator * rational1.denominator);
			int AddDen = rational1.denominator * rational2.denominator;

			int simptop = AddNum / GCD(AddNum, AddDen);
			int simpbot = AddDen / GCD(AddNum, AddDen);
			Add.numerator = simptop;
			Add.denominator = simpbot;
			
			return Add;
		}
	}
}		
	
