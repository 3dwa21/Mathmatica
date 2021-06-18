using Mathmatica.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Mathmatica_UnitTest
{
	[TestClass]
	public class NumberUT
	{
		[TestMethod]
		public void TestConstructors()
		{
			List<decimal> testValuesDecimal = new()
			{
				-5.5m,
				-5m,
				0.0m,
				5m,
				5.5m
			};

			foreach (decimal value in testValuesDecimal)
			{
				Number testInstance = new(value);
				Assert.AreEqual(value, testInstance.Value, string.Format("Number(decimal) constructor"));
			}

			/////////////////////////////////////////////////////////////////////////////////////////

			List<double> testValuesDouble = new()
			{
				-5.5,
				-5,
				0.0,
				5,
				5.5
			};

			foreach (double value in testValuesDouble)
			{
				Number testInstance = new(value);
				Assert.AreEqual(Convert.ToDecimal(value), testInstance.Value, string.Format("Number(double) constructor"));
			}

			/////////////////////////////////////////////////////////////////////////////////////////

			List<float> testValuesFloat = new()
			{
				-5.5f,
				-5f,
				0.0f,
				5f,
				5.5f
			};

			foreach (float value in testValuesFloat)
			{
				Number testInstance = new(value);
				Assert.AreEqual(Convert.ToDecimal(value), testInstance.Value, string.Format("Number(float) constructor"));
			}

			/////////////////////////////////////////////////////////////////////////////////////////

			List<int> testValuesInt = new()
			{
				-5,
				0,
				5,
			};

			foreach (int value in testValuesInt)
			{
				Number testInstance = new(value);
				Assert.AreEqual(Convert.ToDecimal(value), testInstance.Value, string.Format("Number(int) constructor"));
			}

			/////////////////////////////////////////////////////////////////////////////////////////

			List<Number> testValuesNumber = new()
			{
				new Number(-5.5m),
				new Number(-5m),
				new Number(0.0m),
				new Number(5m),
				new Number(5.5m)
			};

			foreach (Number value in testValuesNumber)
			{
				Number testInstance = value;
				Assert.AreEqual(value.Value, testInstance.Value, string.Format("Number(Number) constructor"));
			}
		}

		[TestMethod]
		public void TestUnaryOperators()
		{
			List<Number> testValues = new()
			{
				new Number(-5.5m),
				new Number(-5m),
				new Number(0.0m),
				new Number(5m),
				new Number(5.5m)
			};

			foreach (Number value in testValues)
			{
				Number testInstance = new(value);
				Assert.AreEqual(value.Value, +testInstance.Value, string.Format("Number unary operator plus"));
			}

			/////////////////////////////////////////////////////////////////////////////////////////

			foreach (Number value in testValues)
			{
				Number testInstance = new(value);
				Assert.AreEqual(0 - value.Value, -testInstance.Value, string.Format("Number unary operator minus"));
			}

			/////////////////////////////////////////////////////////////////////////////////////////

			foreach (Number value in testValues)
			{
				Number testInstance = new(value);
				Assert.AreEqual(value.Value + 1, ++testInstance.Value, string.Format("Number unary operator increment"));
			}

			/////////////////////////////////////////////////////////////////////////////////////////

			foreach (Number value in testValues)
			{
				Number testInstance = new(value);
				Assert.AreEqual(value.Value - 1, --testInstance.Value, string.Format("Number unary operator decrement"));
			}
		}

		[TestMethod]
		public void TestAdditionOperator()
		{
			Assert.AreEqual(0m, new Number(new Number(-5.5m) + 5.5m).Value, string.Format("Number addition with decimal"));
			Assert.AreEqual(0m, new Number(new Number(-5.5m) + 5.5).Value, string.Format("Number addition with double"));
			Assert.AreEqual(0m, new Number(new Number(-5.5m) + 5.5f).Value, string.Format("Number addition with float"));
			Assert.AreEqual(-0.5m, new Number(new Number(-5.5m) + 5).Value, string.Format("Number addition with int"));
			Assert.AreEqual(0m, new Number(new Number(-5.5m) + new Number(5.5m)).Value, string.Format("Number addition with Number"));
		}

		[TestMethod]
		public void TestSubstractionOperator()
		{
			Assert.AreEqual(-11m, new Number(new Number(-5.5m) - 5.5m).Value, string.Format("Number substraction with decimal"));
			Assert.AreEqual(-11m, new Number(new Number(-5.5m) - 5.5).Value, string.Format("Number substraction with double"));
			Assert.AreEqual(-11m, new Number(new Number(-5.5m) - 5.5f).Value, string.Format("Number substraction with float"));
			Assert.AreEqual(-10.5m, new Number(new Number(-5.5m) - 5).Value, string.Format("Number substraction with int"));
			Assert.AreEqual(-11m, new Number(new Number(-5.5m) - new Number(5.5m)).Value, string.Format("Number substraction with Number"));
		}

		[TestMethod]
		public void TestMultiplicationOperator()
		{
			Assert.AreEqual(-30.25m, new Number(new Number(-5.5m) * 5.5m).Value, string.Format("Number multiplication with decimal"));
			Assert.AreEqual(-30.25m, new Number(new Number(-5.5m) * 5.5).Value, string.Format("Number multiplication with double"));
			Assert.AreEqual(-30.25m, new Number(new Number(-5.5m) * 5.5f).Value, string.Format("Number multiplication with float"));
			Assert.AreEqual(-27.5m, new Number(new Number(-5.5m) * 5).Value, string.Format("Number multiplication with int"));
			Assert.AreEqual(-30.25m, new Number(new Number(-5.5m) * new Number(5.5m)).Value, string.Format("Number multiplication with Number"));
		}

		[TestMethod]
		public void TestDivisionOperator()
		{
			Assert.AreEqual(-1m, new Number(new Number(-5.5m) / 5.5m).Value, string.Format("Number division with decimal"));
			Assert.AreEqual(-1m, new Number(new Number(-5.5m) / 5.5).Value, string.Format("Number division with double"));
			Assert.AreEqual(-1m, new Number(new Number(-5.5m) / 5.5f).Value, string.Format("Number division with float"));
			Assert.AreEqual(-1.1m, new Number(new Number(-5.5m) / 5).Value, string.Format("Number division with int"));
			Assert.AreEqual(-1m, new Number(new Number(-5.5m) / new Number(5.5m)).Value, string.Format("Number division with Number"));
		}

		[TestMethod]
		public void TestRemainderOperator()
		{
			Assert.AreEqual(-.5m, new Number(new Number(-5.5m) % 5m).Value, string.Format("Number remainder with decimal"));
			Assert.AreEqual(-.5m, new Number(new Number(-5.5m) % 5).Value, string.Format("Number remainder with double"));
			Assert.AreEqual(-.5m, new Number(new Number(-5.5m) % 5f).Value, string.Format("Number remainder with float"));
			Assert.AreEqual(-.5m, new Number(new Number(-5.5m) % 5).Value, string.Format("Number remainder with int"));
			Assert.AreEqual(-.5m, new Number(new Number(-5.5m) % new Number(5m)).Value, string.Format("Number remainder with Number"));
		}

		[TestMethod]
		public void TestEqualOperator()
		{
			Assert.AreEqual(true, new Number(5.5m) == 5.5m, string.Format("Number equal with decimal"));
			Assert.AreEqual(true, new Number(5.5m) == 5.5, string.Format("Number equal with double"));
			Assert.AreEqual(true, new Number(5.5m) == 5.5f, string.Format("Number equal with float"));
			Assert.AreEqual(true, new Number(5m) == 5, string.Format("Number equal with int"));
			Assert.AreEqual(true, new Number(5.5m) == new Number(5.5m), string.Format("Number equal with Number"));
		}

		[TestMethod]
		public void TestNotEqualOperator()
		{
			Assert.AreEqual(true, new Number(-5.5m) != 5.5m, string.Format("Number not equal with decimal"));
			Assert.AreEqual(true, new Number(-5.5m) != 5.5, string.Format("Number not equal with double"));
			Assert.AreEqual(true, new Number(-5.5m) != 5.5f, string.Format("Number not equal with float"));
			Assert.AreEqual(true, new Number(-5m) != 5, string.Format("Number not equal with int"));
			Assert.AreEqual(true, new Number(-5.5m) != new Number(5.5m), string.Format("Number not equal with Number"));
		}

		[TestMethod]
		public void TestLessOperator()
		{
			Assert.AreEqual(true, new Number(-5.5m) < 5.5m, string.Format("Number less with decimal"));
			Assert.AreEqual(true, new Number(-5.5m) < 5.5, string.Format("Number less with double"));
			Assert.AreEqual(true, new Number(-5.5m) < 5.5f, string.Format("Number less with float"));
			Assert.AreEqual(true, new Number(-5m) < 5, string.Format("Number less with int"));
			Assert.AreEqual(true, new Number(-5.5m) < new Number(5.5m), string.Format("Number less with Number"));
		}

		[TestMethod]
		public void TestGreaterOperator()
		{
			Assert.AreEqual(true, new Number(5.5m) > -5.5m, string.Format("Number greater with decimal"));
			Assert.AreEqual(true, new Number(5.5m) > -5.5, string.Format("Number greater with double"));
			Assert.AreEqual(true, new Number(5.5m) > -5.5f, string.Format("Number greater with float"));
			Assert.AreEqual(true, new Number(5m) > -5, string.Format("Number greater with int"));
			Assert.AreEqual(true, new Number(5.5m) > new Number(-5.5m), string.Format("Number greater with Number"));
		}

		[TestMethod]
		public void TestLessOrEqualOperator()
		{
			Assert.AreEqual(true, new Number(-5.5m) <= 5.5m, string.Format("Number less or equal with decimal"));
			Assert.AreEqual(true, new Number(-5.5m) <= 5.5, string.Format("Number less or equal with double"));
			Assert.AreEqual(true, new Number(-5.5m) <= 5.5f, string.Format("Number less or equal with float"));
			Assert.AreEqual(true, new Number(-5m) <= 5, string.Format("Number less or equal with int"));
			Assert.AreEqual(true, new Number(-5.5m) <= new Number(5.5m), string.Format("Number less or equal with Number"));
			Assert.AreEqual(true, new Number(5.5m) <= 5.5m, string.Format("Number less or equal with decimal"));
			Assert.AreEqual(true, new Number(5.5m) <= 5.5, string.Format("Number less or equal with double"));
			Assert.AreEqual(true, new Number(5.5m) <= 5.5f, string.Format("Number less or equal with float"));
			Assert.AreEqual(true, new Number(5m) <= 5, string.Format("Number less or equal with int"));
			Assert.AreEqual(true, new Number(5.5m) <= new Number(5.5m), string.Format("Number less or equal with Number"));
		}

		[TestMethod]
		public void TestGreaterOrEqualOperator()
		{
			Assert.AreEqual(true, new Number(5.5m) >= -5.5m, string.Format("Number greater or equal with decimal"));
			Assert.AreEqual(true, new Number(5.5m) >= -5.5, string.Format("Number greater or equal with double"));
			Assert.AreEqual(true, new Number(5.5m) >= -5.5f, string.Format("Number greater or equal with float"));
			Assert.AreEqual(true, new Number(5m) >= -5, string.Format("Number greater or equal with int"));
			Assert.AreEqual(true, new Number(5.5m) >= new Number(-5.5m), string.Format("Number greater or equal with Number"));
			Assert.AreEqual(true, new Number(5.5m) >= 5.5m, string.Format("Number greater or equal with decimal"));
			Assert.AreEqual(true, new Number(5.5m) >= 5.5, string.Format("Number greater or equal with double"));
			Assert.AreEqual(true, new Number(5.5m) >= 5.5f, string.Format("Number greater or equal with float"));
			Assert.AreEqual(true, new Number(5m) >= 5, string.Format("Number greater or equal with int"));
			Assert.AreEqual(true, new Number(5.5m) >= new Number(5.5m), string.Format("Number greater or equal with Number"));
		}
	}
}
