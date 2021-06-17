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
		///		Adding two numbers.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator +(Number number1, Number number2)
		{
			return Number.OperationBaseMath(number1, number2, BaseMathOperation.Add);
		}

		/// <summary>
		///		Adding Number with decimal.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator +(Number number1, decimal number2)
		{
			return Number.OperationBaseMath(number1, new Number(number2), BaseMathOperation.Add);
		}

		/// <summary>
		///		Adding Number with double.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator +(Number number1, double number2)
		{
			return Number.OperationBaseMath(number1, new Number(number2), BaseMathOperation.Add);
		}

		/// <summary>
		///		Adding Number with float.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator +(Number number1, float number2)
		{
			return Number.OperationBaseMath(number1, new Number(number2), BaseMathOperation.Add);
		}

		/// <summary>
		///		Adding Number with int.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator +(Number number1, int number2)
		{
			return Number.OperationBaseMath(number1, new Number(number2), BaseMathOperation.Add);
		}

		/// <summary>
		///		Substract two numbers.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator -(Number number1, Number number2)
		{
			return Number.OperationBaseMath(number1, number2, BaseMathOperation.Substract);
		}

		/// <summary>
		///		Substract number with decimal.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator -(Number number1, decimal number2)
		{
			return Number.OperationBaseMath(number1, new Number(number2), BaseMathOperation.Substract);
		}

		/// <summary>
		///		Substract number with double.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator -(Number number1, double number2)
		{
			return Number.OperationBaseMath(number1, new Number(number2), BaseMathOperation.Substract);
		}

		/// <summary>
		///		Substract number with float.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator -(Number number1, float number2)
		{
			return Number.OperationBaseMath(number1, new Number(number2), BaseMathOperation.Substract);
		}

		/// <summary>
		///		Substract number with int.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator -(Number number1, int number2)
		{
			return Number.OperationBaseMath(number1, new Number(number2), BaseMathOperation.Substract);
		}

		/// <summary>
		///		Multiply two numbers.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator *(Number number1, Number number2)
		{
			return Number.OperationBaseMath(number1, number2, BaseMathOperation.Multiply);
		}

		/// <summary>
		///		Multiply number with decimal.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator *(Number number1, decimal number2)
		{
			return Number.OperationBaseMath(number1, new Number(number2), BaseMathOperation.Multiply);
		}

		/// <summary>
		///		Multiply number with double.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator *(Number number1, double number2)
		{
			return Number.OperationBaseMath(number1, new Number(number2), BaseMathOperation.Multiply);
		}

		/// <summary>
		///		Multiply number with float.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator *(Number number1, float number2)
		{
			return Number.OperationBaseMath(number1, new Number(number2), BaseMathOperation.Multiply);
		}

		/// <summary>
		///		Multiply number with int.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator *(Number number1, int number2)
		{
			return Number.OperationBaseMath(number1, new Number(number2), BaseMathOperation.Multiply);
		}

		/// <summary>
		///		Divide two numbers.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator /(Number number1, Number number2)
		{
			return Number.OperationBaseMath(number1, number2, BaseMathOperation.Divide);
		}

		/// <summary>
		///		Divide number with decimal.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator /(Number number1, decimal number2)
		{
			return Number.OperationBaseMath(number1, new Number(number2), BaseMathOperation.Divide);
		}

		/// <summary>
		///		Divide number with double.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator /(Number number1, double number2)
		{
			return Number.OperationBaseMath(number1, new Number(number2), BaseMathOperation.Divide);
		}

		/// <summary>
		///		Divide number with float.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator /(Number number1, float number2)
		{
			return Number.OperationBaseMath(number1, new Number(number2), BaseMathOperation.Divide);
		}

		/// <summary>
		///		Divide number with int.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static Number operator /(Number number1, int number2)
		{
			return Number.OperationBaseMath(number1, new Number(number2), BaseMathOperation.Divide);
		}

		/// <summary>
		///		Base algo for Number math operators
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <param name="baseMathOperation"></param>
		/// <returns></returns>
		private static Number OperationBaseMath(Number number1, Number number2, BaseMathOperation baseMathOperation)
		{
			if (Utils.IsAnyNull(number1, number2))
			{
				throw new ArgumentNullException();
			}

			switch (baseMathOperation)
			{
				case BaseMathOperation.Add:
					return new Number(number1.Value + number2.Value);
				case BaseMathOperation.Substract:
					return new Number(number1.Value - number2.Value);
				case BaseMathOperation.Multiply:
					return new Number(number1.Value * number2.Value);
				case BaseMathOperation.Divide:
					return new Number(number1.Value / number2.Value);
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
			return Number.OperationBaseLogic(number1, number2, BaseLogicOperation.Equal);
		}

		/// <summary>
		///		Compare Number with decimal equal.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static bool operator ==(Number number1, decimal number2)
		{
			return Number.OperationBaseLogic(number1, new Number(number2), BaseLogicOperation.Equal);
		}

		/// <summary>
		///		Compare Number with double equal.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static bool operator ==(Number number1, double number2)
		{
			return Number.OperationBaseLogic(number1, new Number(number2), BaseLogicOperation.Equal);
		}

		/// <summary>
		///		Compare Number with float equal.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static bool operator ==(Number number1, float number2)
		{
			return Number.OperationBaseLogic(number1, new Number(number2), BaseLogicOperation.Equal);
		}

		/// <summary>
		///		Compare Number with int equal.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static bool operator ==(Number number1, int number2)
		{
			return Number.OperationBaseLogic(number1, new Number(number2), BaseLogicOperation.Equal);
		}

		/// <summary>
		///		Compare two Numbers not equal.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static bool operator !=(Number number1, Number number2)
		{
			return Number.OperationBaseLogic(number1, number2, BaseLogicOperation.NotEqual);
		}

		/// <summary>
		///		Compare Number with decimal not equal.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static bool operator !=(Number number1, decimal number2)
		{
			return Number.OperationBaseLogic(number1, new Number(number2), BaseLogicOperation.NotEqual);
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
			return Number.OperationBaseLogic(number1, new Number(number2), BaseLogicOperation.NotEqual);
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
			return Number.OperationBaseLogic(number1, new Number(number2), BaseLogicOperation.NotEqual);
		}

		/// <summary>
		///		Compare Number with int not equal.
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <returns></returns>
		public static bool operator !=(Number number1, int number2)
		{
			return Number.OperationBaseLogic(number1, new Number(number2), BaseLogicOperation.NotEqual);
		}

		/// <summary>
		///		Base algo for Number logic operators
		/// </summary>
		/// <param name="number1"></param>
		/// <param name="number2"></param>
		/// <param name="baseMathOperation"></param>
		/// <returns></returns>
		private static bool OperationBaseLogic(Number number1, Number number2, BaseLogicOperation baseLogicOperation)
		{
			if (Utils.IsAnyNull(number1, number2))
			{
				throw new ArgumentNullException();
			}

			switch (baseLogicOperation)
			{
				case BaseLogicOperation.Equal:
					return number1.Value == number2.Value;
				case BaseLogicOperation.NotEqual:
					return number1.Value != number2.Value;
				default:
					throw new ArgumentException();
			}
		}
		#endregion

		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		// Operations
		#region Operations
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
