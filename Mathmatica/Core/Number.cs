using Mathmatica.Enums;
using Mathmatica.Interfaces;
using System;

namespace Mathmatica.Core
{
	public class Number : INumber
	{
		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		/// Properties & Fields
		/// 
		public decimal Value { get; set; }

		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		// Constructor Management

		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		// Constructors
		#region Contructors
		/// <summary>
		///		Contructor for Number with Number input
		/// </summary>
		/// <param name="value"></param>
		public Number(Number number)
		{
			this.NumberConstructorBase(number.Value);
		}

		/// <summary>
		///		Contructor for Number with decimal input
		/// </summary>
		/// <param name="value"></param>
		public Number(decimal value)
		{
			this.Value = value;
		}

		/// <summary>
		///		Contructor for Number with double input
		/// </summary>
		/// <param name="value"></param>
		public Number(double value)
		{
			this.NumberConstructorBase(value);
		}

		/// <summary>
		///		Contructor for Number with float input
		/// </summary>
		/// <param name="value"></param>
		public Number(float value)
		{
			this.NumberConstructorBase(value);
		}

		/// <summary>
		///		Contructor for Number with int input
		/// </summary>
		/// <param name="value"></param>
		public Number(int value)
		{
			this.NumberConstructorBase(value);
		}

		/// <summary>
		///		Base algo for creating new Number object
		/// </summary>
		/// <param name="value"></param>
		private void NumberConstructorBase<T>(T value)
		{
			this.Value = Convert.ToDecimal(value);
		}
		#endregion

		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		// Destructors

		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		// Operators
		#region Operators
		/// <summary>
		///		Unary plus operator for Number
		/// </summary>
		/// <param name="number"></param>
		/// <returns></returns>
		public static Number operator +(Number number)
		{
			return new Number(number);
		}

		/// <summary>
		///		Unary minus operator for Number
		/// </summary>
		/// <param name="number"></param>
		/// <returns></returns>
		public static Number operator -(Number number)
		{
			return new Number(-number.Value);
		}

		/// <summary>
		///		Increment operator for Number
		/// </summary>
		/// <param name="number"></param>
		/// <returns></returns>
		public static Number operator ++(Number number)
		{
			return new Number(number.Value + 1);
		}

		/// <summary>
		///		Decrement operator for Number
		/// </summary>
		/// <param name="number"></param>
		/// <returns></returns>
		public static Number operator --(Number number)
		{
			return new Number(number.Value - 1);
		}

		/// <summary>
		///		Adding two numbers.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator +(Number number1, Number number2)
		{
			return Number.OperationBaseArithmetic(number1, number2, BaseArithmeticOperation.Addition);
		}

		/// <summary>
		///		Adding Number with decimal.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator +(Number number1, decimal number2)
		{
			return Number.OperationBaseArithmetic(number1, new Number(number2), BaseArithmeticOperation.Addition);
		}

		/// <summary>
		///		Adding Number with double.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator +(Number number1, double number2)
		{
			return Number.OperationBaseArithmetic(number1, new Number(number2), BaseArithmeticOperation.Addition);
		}

		/// <summary>
		///		Adding Number with float.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator +(Number number1, float number2)
		{
			return Number.OperationBaseArithmetic(number1, new Number(number2), BaseArithmeticOperation.Addition);
		}

		/// <summary>
		///		Adding Number with int.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator +(Number number1, int number2)
		{
			return Number.OperationBaseArithmetic(number1, new Number(number2), BaseArithmeticOperation.Addition);
		}

		/// <summary>
		///		Substract two numbers.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator -(Number number1, Number number2)
		{
			return Number.OperationBaseArithmetic(number1, number2, BaseArithmeticOperation.Substraction);
		}

		/// <summary>
		///		Substract number with decimal.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator -(Number number1, decimal number2)
		{
			return Number.OperationBaseArithmetic(number1, new Number(number2), BaseArithmeticOperation.Substraction);
		}

		/// <summary>
		///		Substract number with double.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator -(Number number1, double number2)
		{
			return Number.OperationBaseArithmetic(number1, new Number(number2), BaseArithmeticOperation.Substraction);
		}

		/// <summary>
		///		Substract number with float.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator -(Number number1, float number2)
		{
			return Number.OperationBaseArithmetic(number1, new Number(number2), BaseArithmeticOperation.Substraction);
		}

		/// <summary>
		///		Substract number with int.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator -(Number number1, int number2)
		{
			return Number.OperationBaseArithmetic(number1, new Number(number2), BaseArithmeticOperation.Substraction);
		}

		/// <summary>
		///		Multiply two numbers.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator *(Number number1, Number number2)
		{
			return Number.OperationBaseArithmetic(number1, number2, BaseArithmeticOperation.Multiplication);
		}

		/// <summary>
		///		Multiply number with decimal.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator *(Number number1, decimal number2)
		{
			return Number.OperationBaseArithmetic(number1, new Number(number2), BaseArithmeticOperation.Multiplication);
		}

		/// <summary>
		///		Multiply number with double.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator *(Number number1, double number2)
		{
			return Number.OperationBaseArithmetic(number1, new Number(number2), BaseArithmeticOperation.Multiplication);
		}

		/// <summary>
		///		Multiply number with float.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator *(Number number1, float number2)
		{
			return Number.OperationBaseArithmetic(number1, new Number(number2), BaseArithmeticOperation.Multiplication);
		}

		/// <summary>
		///		Multiply number with int.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator *(Number number1, int number2)
		{
			return Number.OperationBaseArithmetic(number1, new Number(number2), BaseArithmeticOperation.Multiplication);
		}

		/// <summary>
		///		Divide two numbers.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator /(Number number1, Number number2)
		{
			return Number.OperationBaseArithmetic(number1, number2, BaseArithmeticOperation.Division);
		}

		/// <summary>
		///		Divide number with decimal.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator /(Number number1, decimal number2)
		{
			return Number.OperationBaseArithmetic(number1, new Number(number2), BaseArithmeticOperation.Division);
		}

		/// <summary>
		///		Divide number with double.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator /(Number number1, double number2)
		{
			return Number.OperationBaseArithmetic(number1, new Number(number2), BaseArithmeticOperation.Division);
		}

		/// <summary>
		///		Divide number with float.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator /(Number number1, float number2)
		{
			return Number.OperationBaseArithmetic(number1, new Number(number2), BaseArithmeticOperation.Division);
		}

		/// <summary>
		///		Divide number with int.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator /(Number number1, int number2)
		{
			return Number.OperationBaseArithmetic(number1, new Number(number2), BaseArithmeticOperation.Division);
		}

		/// <summary>
		///		Reminder of two numbers.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator %(Number number1, Number number2)
		{
			return Number.OperationBaseArithmetic(number1, number2, BaseArithmeticOperation.Remainder);
		}

		/// <summary>
		///		Reminder number with decimal.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator %(Number number1, decimal number2)
		{
			return Number.OperationBaseArithmetic(number1, new Number(number2), BaseArithmeticOperation.Remainder);
		}

		/// <summary>
		///		Reminder number with double.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator %(Number number1, double number2)
		{
			return Number.OperationBaseArithmetic(number1, new Number(number2), BaseArithmeticOperation.Remainder);
		}

		/// <summary>
		///		Reminder number with float.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator %(Number number1, float number2)
		{
			return Number.OperationBaseArithmetic(number1, new Number(number2), BaseArithmeticOperation.Remainder);
		}

		/// <summary>
		///		Reminder number with int.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator %(Number number1, int number2)
		{
			return Number.OperationBaseArithmetic(number1, new Number(number2), BaseArithmeticOperation.Remainder);
		}

		/// <summary>
		///		Base algo for Number math operators
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <param name="baseMathOperation"></param>
		/// <returns></returns>
		private static Number OperationBaseArithmetic(Number number1, Number number2, BaseArithmeticOperation baseMathOperation)
		{
			if (Utils.IsAnyNull(number1, number2))
			{
				throw new ArgumentNullException();
			}

			switch (baseMathOperation)
			{
				case BaseArithmeticOperation.Addition:
					return new Number(number1.Value + number2.Value);
				case BaseArithmeticOperation.Substraction:
					return new Number(number1.Value - number2.Value);
				case BaseArithmeticOperation.Multiplication:
					return new Number(number1.Value * number2.Value);
				case BaseArithmeticOperation.Division:
					return new Number(number1.Value / number2.Value);
				case BaseArithmeticOperation.Remainder:
					return new Number(number1.Value % number2.Value);
				default:
					throw new ArgumentException();
			}
		}

		/// <summary>
		///		Compare two Numbers equal.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static bool operator ==(Number number1, Number number2)
		{
			return Number.OperationBaseLogic(number1, number2, BaseComparisonOperation.Equal);
		}

		/// <summary>
		///		Compare Number with decimal equal.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static bool operator ==(Number number1, decimal number2)
		{
			return Number.OperationBaseLogic(number1, new Number(number2), BaseComparisonOperation.Equal);
		}

		/// <summary>
		///		Compare Number with double equal.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static bool operator ==(Number number1, double number2)
		{
			return Number.OperationBaseLogic(number1, new Number(number2), BaseComparisonOperation.Equal);
		}

		/// <summary>
		///		Compare Number with float equal.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static bool operator ==(Number number1, float number2)
		{
			return Number.OperationBaseLogic(number1, new Number(number2), BaseComparisonOperation.Equal);
		}

		/// <summary>
		///		Compare Number with int equal.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static bool operator ==(Number number1, int number2)
		{
			return Number.OperationBaseLogic(number1, new Number(number2), BaseComparisonOperation.Equal);
		}

		/// <summary>
		///		Compare two Numbers not equal.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static bool operator !=(Number number1, Number number2)
		{
			return Number.OperationBaseLogic(number1, number2, BaseComparisonOperation.NotEqual);
		}

		/// <summary>
		///		Compare Number with decimal not equal.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static bool operator !=(Number number1, decimal number2)
		{
			return Number.OperationBaseLogic(number1, new Number(number2), BaseComparisonOperation.NotEqual);
		}

		/// <summary>
		///		Compare Number with double not equal.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		/// 
		public static bool operator !=(Number number1, double number2)
		{
			return Number.OperationBaseLogic(number1, new Number(number2), BaseComparisonOperation.NotEqual);
		}

		/// <summary>
		///		Compare Number with float not equal.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		/// 
		public static bool operator !=(Number number1, float number2)
		{
			return Number.OperationBaseLogic(number1, new Number(number2), BaseComparisonOperation.NotEqual);
		}

		/// <summary>
		///		Compare Number with int not equal.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static bool operator !=(Number number1, int number2)
		{
			return Number.OperationBaseLogic(number1, new Number(number2), BaseComparisonOperation.NotEqual);
		}

		/// <summary>
		///		Compare Number less then Number.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static bool operator <(Number number1, Number number2)
		{
			return Number.OperationBaseLogic(number1, number2, BaseComparisonOperation.Less);
		}

		/// <summary>
		///		Compare Number less then decimal.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static bool operator <(Number number1, decimal number2)
		{
			return Number.OperationBaseLogic(number1, new Number(number2), BaseComparisonOperation.Less);
		}

		/// <summary>
		///		Compare Number less then double.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static bool operator <(Number number1, double number2)
		{
			return Number.OperationBaseLogic(number1, new Number(number2), BaseComparisonOperation.Less);
		}

		/// <summary>
		///		Compare Number less then float.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static bool operator <(Number number1, float number2)
		{
			return Number.OperationBaseLogic(number1, new Number(number2), BaseComparisonOperation.Less);
		}

		/// <summary>
		///		Compare Number less then int.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static bool operator <(Number number1, int number2)
		{
			return Number.OperationBaseLogic(number1, new Number(number2), BaseComparisonOperation.Less);
		}

		/// <summary>
		///		Compare Number greater then Number.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static bool operator >(Number number1, Number number2)
		{
			return Number.OperationBaseLogic(number1, number2, BaseComparisonOperation.Greater);
		}

		/// <summary>
		///		Compare Number greater then decimal.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static bool operator >(Number number1, decimal number2)
		{
			return Number.OperationBaseLogic(number1, new Number(number2), BaseComparisonOperation.Greater);
		}

		/// <summary>
		///		Compare Number greater then double.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static bool operator >(Number number1, double number2)
		{
			return Number.OperationBaseLogic(number1, new Number(number2), BaseComparisonOperation.Greater);
		}

		/// <summary>
		///		Compare Number greater then float.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static bool operator >(Number number1, float number2)
		{
			return Number.OperationBaseLogic(number1, new Number(number2), BaseComparisonOperation.Greater);
		}

		/// <summary>
		///		Compare Number greater then int.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static bool operator >(Number number1, int number2)
		{
			return Number.OperationBaseLogic(number1, new Number(number2), BaseComparisonOperation.Greater);
		}

		/// <summary>
		///		Compare Number less then or equal to Number.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static bool operator <=(Number number1, Number number2)
		{
			return Number.OperationBaseLogic(number1, number2, BaseComparisonOperation.LessEquals);
		}

		/// <summary>
		///		Compare Number less then or equal to decimal.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static bool operator <=(Number number1, decimal number2)
		{
			return Number.OperationBaseLogic(number1, new Number(number2), BaseComparisonOperation.LessEquals);
		}

		/// <summary>
		///		Compare Number less then or equal to double.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static bool operator <=(Number number1, double number2)
		{
			return Number.OperationBaseLogic(number1, new Number(number2), BaseComparisonOperation.LessEquals);
		}

		/// <summary>
		///		Compare Number less then or equal to float.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static bool operator <=(Number number1, float number2)
		{
			return Number.OperationBaseLogic(number1, new Number(number2), BaseComparisonOperation.LessEquals);
		}

		/// <summary>
		///		Compare Number less then or equal to int.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static bool operator <=(Number number1, int number2)
		{
			return Number.OperationBaseLogic(number1, new Number(number2), BaseComparisonOperation.LessEquals);
		}

		/// <summary>
		///		Compare Number greater then or equal to Number.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static bool operator >=(Number number1, Number number2)
		{
			return Number.OperationBaseLogic(number1, number2, BaseComparisonOperation.GreaterEquals);
		}

		/// <summary>
		///		Compare Number greater then or equal to decimal.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static bool operator >=(Number number1, decimal number2)
		{
			return Number.OperationBaseLogic(number1, new Number(number2), BaseComparisonOperation.GreaterEquals);
		}

		/// <summary>
		///		Compare Number greater then or equal to double.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static bool operator >=(Number number1, double number2)
		{
			return Number.OperationBaseLogic(number1, new Number(number2), BaseComparisonOperation.GreaterEquals);
		}

		/// <summary>
		///		Compare Number greater then or equal to float.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static bool operator >=(Number number1, float number2)
		{
			return Number.OperationBaseLogic(number1, new Number(number2), BaseComparisonOperation.GreaterEquals);
		}

		/// <summary>
		///		Compare Number greater then or equal to int.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static bool operator >=(Number number1, int number2)
		{
			return Number.OperationBaseLogic(number1, new Number(number2), BaseComparisonOperation.GreaterEquals);
		}

		/// <summary>
		///		Base algo for Number logic operators
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <param name="baseMathOperation"></param>
		/// <returns></returns>
		private static bool OperationBaseLogic(Number number1, Number number2, BaseComparisonOperation baseLogicOperation)
		{
			if (Utils.IsAnyNull(number1, number2))
			{
				throw new ArgumentNullException();
			}

			switch (baseLogicOperation)
			{
				case BaseComparisonOperation.Equal:
					return number1.Value == number2.Value;
				case BaseComparisonOperation.NotEqual:
					return number1.Value != number2.Value;
				case BaseComparisonOperation.Less:
					return number1.Value < number2.Value;
				case BaseComparisonOperation.Greater:
					return number1.Value > number2.Value;
				case BaseComparisonOperation.LessEquals:
					return number1.Value <= number2.Value;
				case BaseComparisonOperation.GreaterEquals:
					return number1.Value >= number2.Value;
				default:
					throw new ArgumentException();
			}
		}
		#endregion

		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		// Methods
		#region Methods
		/// <summary>
		///		Checks Equality
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public override bool Equals(object obj)
		{
			return obj is Number number &&
				   Value == number.Value;
		}

		/// <summary>
		///		Returns Hash Code
		/// </summary>
		/// <returns></returns>
		public override int GetHashCode()
		{
			return -1937169414 + Value.GetHashCode();
		}

		/// <summary>
		///		Print values of number in console
		/// </summary>
		public void PrintValues()
		{
			Console.WriteLine(this.Value.ToString());
		}
		#endregion
	}
}
