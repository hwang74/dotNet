using System;

namespace mod2Lab1
{
	class Program
	{
		static void Main (string[] args)
		{
			int result = Sum (20, 40);
			Console.WriteLine ($"Calling Sum() with two arguments, the sum of 20 and 40 is : {result}");

			int result2 = Sum (20, 40, 60);
			Console.WriteLine ($"Calling Sum() with three arguments, the sum of 20, 40, and 60 is : {result2}");

			double dblResult = Sum(20.5, 30.6);
			Console.WriteLine ($"Calling Sum() with double arguments, the sum of 20.5 and 30.6 is : {dblResult}");
		}

		static int Sum (int first, int second)
		{
			int sum = first + second;
			return sum;
		}

		// overloading
		static int Sum (int first, int second, int third)
		{
			int sum = first + second + third;
			return sum;
		}

		// overloading
		static double Sum (double first, double second)
		{
			double result = first + second;
			return result;
		}
	}
}