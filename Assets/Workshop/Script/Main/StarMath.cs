using System;
using Utilities.Contract;

namespace Main
{
	public class StarMath
	{
		public int Add(int number1, int number2) {
			var number1IsPositive = IsNumberPositive(number1);
			var number2IsPositive = IsNumberPositive(number2);
			Contract.Require(number1IsPositive || number2IsPositive,"number1 and number2 is negative number.");
			Contract.Require(number1IsPositive,"number1 is negative number.");
			Contract.Require(number2IsPositive,"number2 is negative number.");
			//Method Body
			var result = number1 + number2;
			//Post Condition
			Contract.Ensure(result == number1 + number2, "add function doesn't work.");
			Contract.Ensure(result >= 0, "result should be positive number.");
			return result;
		}

		private bool IsNumberPositive(int number) {
			return number >= 0;
		}
	}
}