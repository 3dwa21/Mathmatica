using DecimalMathLib;
using Mathmatica.Interfaces;
using System;

namespace Mathmatica.Core
{
	public class ComplexNumber : INumber
	{
		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		/// Properties & Fields
		/// 
		public decimal Value { get; set; }
		private readonly decimal imaginaryValue;

		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		// Constructor Management

		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		// Constructors
		#region Contructors
		public ComplexNumber(decimal realPart, decimal imaginaryPart)
		{
			this.Value = realPart;
			this.imaginaryValue = imaginaryPart;
		}
		#endregion

		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		// Destructors

		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		// Operators
		// TODO -> Multiplication / Division
		// TODO -> all operations with other numeric types!
		#region Operators
		/// <summary>
		///		Adding two complex numbers together.
		/// </summary>
		/// <param name="complex1"></param>
		/// <param name="complex2"></param>
		/// <returns></returns>
		public static ComplexNumber operator +(ComplexNumber complex1, ComplexNumber complex2)
		{
			if (Utils.IsAnyNull(complex1, complex2))
			{
				throw new ArgumentNullException();
			}

			decimal sumRealPart = complex1.Value + complex2.Value;
			decimal sumImaginaryPart = complex1.imaginaryValue + complex2.imaginaryValue;
			return new ComplexNumber(sumRealPart, sumImaginaryPart);
		}

		/// <summary>
		///		Substract two complex numbers together.
		/// </summary>
		/// <param name="complex1"></param>
		/// <param name="complex2"></param>
		/// <returns></returns>
		public static ComplexNumber operator -(ComplexNumber complex1, ComplexNumber complex2)
		{
			if (Utils.IsAnyNull(complex1, complex2))
			{
				throw new ArgumentNullException();
			}

			decimal sumRealPart = complex1.Value - complex2.Value;
			decimal sumImaginaryPart = complex1.imaginaryValue - complex2.imaginaryValue;
			return new ComplexNumber(sumRealPart, sumImaginaryPart);
		}

		/// <summary>
		///		Compare two complex numbers to be equal.
		/// </summary>
		/// <param name="complex1"></param>
		/// <param name="complex2"></param>
		/// <returns></returns>
		public static bool operator ==(ComplexNumber complex1, ComplexNumber complex2)
		{
			if (Utils.IsAnyNull(complex1, complex2))
			{
				throw new ArgumentNullException();
			}

			if (complex1.Value != complex2.Value || complex1.imaginaryValue != complex2.imaginaryValue)
			{
				return false;
			}
			return true;
		}

		/// <summary>
		///		Compare two complex numbers to be not equal.
		/// </summary>
		/// <param name="complex1"></param>
		/// <param name="complex2"></param>
		/// <returns></returns>
		public static bool operator !=(ComplexNumber complex1, ComplexNumber complex2)
		{
			if (Utils.IsAnyNull(complex1, complex2))
			{
				throw new ArgumentNullException();
			}

			if (complex1.Value == complex2.Value || complex1.imaginaryValue == complex2.imaginaryValue)
			{
				return false;
			}
			return true;
		}
		#endregion

		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		// Operations
		#region Operations
		/// <summary>
		///  Returns length of complex number
		/// </summary>
		/// <returns></returns>
		public decimal GetLength()
		{
			return DecimalMath.Sqrt(DecimalMath.Pow(this.Value, 2) + DecimalMath.Pow(this.imaginaryValue, 2));
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
			return obj is ComplexNumber number &&
				   this.Value == number.Value &&
				   this.imaginaryValue == number.imaginaryValue;
		}

		/// <summary>
		///		Returns Hash Code
		/// </summary>
		/// <returns></returns>
		public override int GetHashCode()
		{
			var hashCode = 1951953771;
			hashCode = hashCode * -1521134295 + Value.GetHashCode();
			hashCode = hashCode * -1521134295 + imaginaryValue.GetHashCode();
			return hashCode;
		}

		/// <summary>
		///		Returns imaginary value of complex number
		/// </summary>
		/// <returns></returns>
		public decimal GetImaginaryValue()
		{
			return this.imaginaryValue;
		}

		/// <summary>
		///		Returns real value of complex number
		/// </summary>
		/// <returns></returns>
		public decimal GetRealValue()
		{
			return this.Value;
		}

		/// <summary>
		///		Print values of complex number in console
		/// </summary>
		public void PrintValues()
		{
			String output = this.Value.ToString();
			if (this.imaginaryValue >= 0)
			{
				output += " + ";
			}
			else
			{
				output += " - ";
			}
			if (Math.Abs(this.imaginaryValue) > 1)
			{
				output += Math.Abs(this.imaginaryValue);
			}
			output += "i";
			Console.WriteLine(output);
		}
		#endregion
	}
}
