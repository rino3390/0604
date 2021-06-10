using System;

namespace Main
{
	public class StarMath
	{
		public int Add(int number1, int number2) {
			var number1IsNegative = IsNumberNegative(number1);
			var number2IsNegative = number2 < 0;
			if (number1IsNegative && number2IsNegative) { throw new Exception("number1 and number2 is negative number."); }
			if (number1IsNegative) { throw new Exception("number1 is negative number."); }
			if (number2IsNegative) { throw new Exception("number2 is negative number."); }
			var result = number1 + number2;
			return result;
		}

		private bool IsNumberNegative(int number) {
			return number < 0;
		}
	}
}