using System.Collections;
using System.Collections.Generic;
using Main;
using NUnit.Framework;
using UnityEngine;

namespace MainTest
{
	public class TestScript
	{
		// A Test behaves as an ordinary method
		[Test]
		[TestCase(1, 2, 3)]
		[TestCase(789, 123, 912)]
		[TestCase(0,0,0)]
		public void Math_Add_Positive_Test(int number1, int number2, int expected) {
			var starMath = new StarMath();
 			var addResult = starMath.Add(number1, number2);
			Assert.AreEqual(expected, addResult);
		}
	}
}