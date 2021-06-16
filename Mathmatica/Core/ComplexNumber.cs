using DecimalMathLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mathmatica.Core
{
	public class ComplexNumber
	{
		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		/// Parameters
		/// 
		private readonly decimal realPart;
		private readonly decimal imaginaryPart;

		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		// Constructor Management

		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		// Constructors
		#region Contructors
		public ComplexNumber(decimal realPart, decimal imaginaryPart)
		{
			this.realPart = realPart;
			this.imaginaryPart = imaginaryPart;
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

			decimal sumRealPart = complex1.realPart + complex2.realPart;
			decimal sumImaginaryPart = complex1.imaginaryPart + complex2.imaginaryPart;
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

			decimal sumRealPart = complex1.realPart - complex2.realPart;
			decimal sumImaginaryPart = complex1.imaginaryPart - complex2.imaginaryPart;
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

			if (complex1.realPart != complex2.realPart || complex1.imaginaryPart != complex2.imaginaryPart)
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

			if (complex1.realPart == complex2.realPart || complex1.imaginaryPart == complex2.imaginaryPart)
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
			return DecimalMath.Sqrt(DecimalMath.Pow(this.realPart, 2) + DecimalMath.Pow(this.imaginaryPart, 2));
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
				   realPart == number.realPart &&
				   imaginaryPart == number.imaginaryPart;
		}

		/// <summary>
		///		Returns Hash Code
		/// </summary>
		/// <returns></returns>
		public override int GetHashCode()
		{
			var hashCode = 1951953771;
			hashCode = hashCode * -1521134295 + realPart.GetHashCode();
			hashCode = hashCode * -1521134295 + imaginaryPart.GetHashCode();
			return hashCode;
		}

		/// <summary>
		///		Returns imaginary part of complex number
		/// </summary>
		/// <returns></returns>
		public decimal GetImaginaryPart()
		{
			return this.imaginaryPart;
		}

		/// <summary>
		///		Returns real part of complex number
		/// </summary>
		/// <returns></returns>
		public decimal GetRealPart()
		{
			return this.realPart;
		}

		/// <summary>
		///		Print values of complex number in console
		/// </summary>
		public void PrintValues()
		{
			String output = this.realPart.ToString();
			if (this.imaginaryPart >= 0)
			{
				output += " + ";
			}
			else
			{
				output += " - ";
			}
			if (Math.Abs(this.imaginaryPart) > 1)
			{
				output += Math.Abs(this.imaginaryPart);
			}
			output += "i";
			Console.WriteLine(output);
		}
		#endregion
	}
}
