using System;
using System.Collections;
using System.Collections.Generic;
using Main;
using NUnit.Framework;
using UnityEngine;
using Utilities.Contract;

namespace MainTest
{
	public class TestScript
	{
		private StarMath _starMath;

		[SetUp]
		public void Setup() {
			_starMath = new StarMath();
		}

		// A Test behaves as an ordinary method
		[Test]
		[TestCase(1, 2, 3)]
		[TestCase(789, 123, 912)]
		[TestCase(0, 0, 0)]
		public void Math_Add_Positive_Test(int number1, int number2, int expected) {
			var addResult = _starMath.Add(number1, number2);
			Assert.AreEqual(expected, addResult);
		}

		[Test]
		[TestCase(-1,0,"number1 is negative number.")]
		[TestCase(0,-1,"number2 is negative number.")]
		[TestCase(-1,-1,"number1 and number2 is negative number.")]
		public void Should_Throw_Exception(int number1, int number2, string errorMessage) {
			var exception = Assert.Throws<PreconditionViolationException>(() => { _starMath.Add(number1, number2); });
			Assert.AreEqual(errorMessage, exception.Message);
		}
	}
}