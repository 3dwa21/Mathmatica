using DecimalMathLib;
using Mathmatica.Exceptions;
using Mathmatica.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mathmatica
{
	public class Vector : IMatrix
	{
		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		/// Properties & Fields
		/// 
		private readonly int n = 0;  // Spalten

		private readonly List<decimal> vector;


		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		// Constructor Management
		#region Constructor Management
		/// <summary>
		///		Constructor for vector with given values
		/// </summary>
		/// <param name="values"></param>
		/// <returns></returns>
		public static Vector CreateVector(params int[] values)
		{
			List<decimal> convertedValues = values.Select<int, decimal>(i => i).ToList();
			return new Vector(convertedValues);
		}

		/// <summary>
		///		Constructor for vector with given values
		/// </summary>
		/// <param name="values"></param>
		/// <returns></returns>
		public static Vector CreateVector(params decimal[] values)
		{
			return new Vector(values.ToList());
		}

		/// <summary>
		///		Constructor for vector with given values
		/// </summary>
		/// <param name="values"></param>
		/// <returns></returns>
		public static Vector CreateVector(params double[] values)
		{
			List<decimal> convertedValues = new List<decimal>();
			foreach (double value in values)
			{
				convertedValues.Add(Convert.ToDecimal(value));
			}
			return new Vector(convertedValues);
		}

		/// <summary>
		///		Constructor for vector with given values
		/// </summary>
		/// <param name="values"></param>
		/// <returns></returns>
		public static Vector CreateVector(params float[] values)
		{
			List<float> line = values.ToList();
			List<decimal> convertedValues = new List<decimal>();

			foreach (var value in line)
			{
				convertedValues.Add(Convert.ToDecimal(value));
			}
			return new Vector(convertedValues);
		}

		/// <summary>
		///		Constructor for vector with given values
		/// </summary>
		/// <param name="values"></param>
		/// <returns></returns>
		public static Vector CreateVector(List<int> values)
		{
			if (values.Any())
			{
				return new Vector(values.Select<int, decimal>(i => i).ToList());
			}

			throw new InvalidSizeException();
		}

		/// <summary>
		///		Constructor for vector with given values
		/// </summary>
		/// <param name="values"></param>
		/// <returns></returns>
		public static Vector CreateVector(List<decimal> values)
		{
			if (values.Any())
			{
				return new Vector(values);
			}

			throw new InvalidSizeException();
		}

		/// <summary>
		///		Constructor for vector with given values
		/// </summary>
		/// <param name="values"></param>
		/// <returns></returns>
		public static Vector CreateVector(List<double> values)
		{
			if (values.Any())
			{
				List<decimal> convertedValues = new List<decimal>();
				foreach (double value in values)
				{
					convertedValues.Add(Convert.ToDecimal(value));
				}
				return new Vector(convertedValues);
			}

			throw new InvalidSizeException();
		}

		/// <summary>
		///		Constructor for vector with given values
		/// </summary>
		/// <param name="values"></param>
		/// <returns></returns>
		public static Vector CreateVector(List<float> values)
		{
			if (values.Any())
			{
				List<decimal> convertedValues = new List<decimal>();
				foreach (var value in values)
				{
					convertedValues.Add(Convert.ToDecimal(value));
				}

				return new Vector(convertedValues);
			}

			throw new InvalidSizeException();
		}

		/// <summary>
		///		Creates vector with values of given vector
		/// </summary>
		/// <param name="values"></param>
		/// <returns></returns>
		public static Vector CreateVector(Vector values)
		{
			return new Vector(values.vector);
		}

		/// <summary>
		///		Creator for zero vector with dimension n
		/// </summary>
		/// <param name="n"></param>
		/// <returns></returns>
		public static Vector CreateZeroVector(int n)
		{
			if (n <= 0)
			{
				throw new InvalidSizeException();
			}
			return new Vector(n);
		}
		#endregion


		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		// Constructors
		#region Constructors
		/// <summary>
		///		Creator for empty vector
		/// </summary>
		/// <param name="n"></param>
		private Vector(int n)
		{
			this.n = n;
			this.vector = Enumerable.Repeat(0m, n).ToList();
		}

		/// <summary>
		///		Creator for vector with given values
		/// </summary>
		/// <param name="vector"></param>
		private Vector(List<decimal> vector)
		{
			this.n = vector.Count;
			this.vector = vector;
		}
		#endregion


		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		// Destructors
		#region Destructors
		#endregion


		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		// Operators
		#region Operators
		/// <summary>
		///		Adding two vectors together.
		/// </summary>
		/// <param name="vector1"></param>
		/// <param name="vector2"></param>
		/// <returns></returns>
		public static Vector operator +(Vector vector1, Vector vector2)
		{
			if (Utils.IsAnyNull(vector1, vector2))
			{
				throw new ArgumentNullException();
			}

			if (vector1.GetDimension() != vector2.GetDimension())
			{
				throw new UnevenDimensionException("Vectors");
			}

			List<decimal> sum = new List<decimal>();
			List<decimal> values1 = vector1.GetValues();
			List<decimal> values2 = vector2.GetValues();

			int n = vector1.GetDimension();

			for (int i = 0; i < n; i++)
			{
				sum.Add(values1[i] + values2[i]);
			}

			return Vector.CreateVector(sum);
		}

		/// <summary>
		///		Subtracting two vectors together.
		/// </summary>
		/// <param name="vector1"></param>
		/// <param name="vector2"></param>
		/// <returns></returns>
		public static Vector operator -(Vector vector1, Vector vector2)
		{
			if (Utils.IsAnyNull(vector1, vector2))
			{
				throw new ArgumentNullException();
			}

			if (vector1.GetDimension() != vector2.GetDimension())
			{
				throw new UnevenDimensionException("Vectors");
			}

			List<decimal> diff = new List<decimal>();
			List<decimal> values1 = vector1.GetValues();
			List<decimal> values2 = vector2.GetValues();

			int n = vector1.GetDimension();

			for (int i = 0; i < n; i++)
			{
				diff.Add(values1[i] - values2[i]);
			}

			return Vector.CreateVector(diff);
		}

		/// <summary>
		///		Multily two vectors
		/// </summary>
		/// <param name="vector1"></param>
		/// <param name="vector2"></param>
		/// <returns></returns>
		public static decimal operator *(Vector vector1, Vector vector2)
		{
			if (Utils.IsAnyNull(vector1, vector2))
			{
				throw new ArgumentNullException();
			}

			if (vector1.GetDimension() != vector2.GetDimension())
			{
				throw new UnevenDimensionException("Matrices");
			}

			decimal product = 0;
			List<decimal> values1 = vector1.GetValues();
			List<decimal> values2 = vector2.GetValues();

			int n = vector1.GetDimension();

			for (int i = 0; i < n; i++)
			{
				product += values1[i] * values2[i];
			}

			return product;
		}

		/// <summary>
		///		Multiply vector with scalar
		/// </summary>
		/// <param name="vector"></param>
		/// <param name="scalar"></param>
		/// <returns></returns>
		public static Vector operator *(Vector vector, decimal scalar)
		{
			if (Utils.IsAnyNull(vector))
			{
				throw new ArgumentNullException();
			}

			int n = vector.GetDimension();
			List<decimal> values = vector.GetValues();
			List<decimal> product = new List<decimal>();

			for (int i = 0; i < n; i++)
			{
				product.Add(values[i] * scalar);
			}

			return Vector.CreateVector(product);
		}

		/// <summary>
		///		Divide vector with scalar
		/// </summary>
		/// <param name="vector"></param>
		/// <param name="scalar"></param>
		/// <returns></returns>
		public static Vector operator /(Vector vector, decimal scalar)
		{
			if (Utils.IsAnyNull(vector))
			{
				throw new ArgumentNullException();
			}

			int n = vector.GetDimension();
			List<decimal> values = vector.GetValues();
			List<decimal> quotient = new List<decimal>();

			for (int i = 0; i < n; i++)
			{
				quotient.Add(values[i] / scalar);
			}

			return Vector.CreateVector(quotient);
		}

		/// <summary>
		///		Compare two vectors to be equal.
		/// </summary>
		/// <param name="vector1"></param>
		/// <param name="vector2"></param>
		/// <returns></returns>
		public static bool operator ==(Vector vector1, Vector vector2)
		{
			if (Utils.IsAnyNull(vector1, vector2))
			{
				throw new ArgumentNullException();
			}

			if (vector1.GetDimension() != vector2.GetDimension())
			{
				return false;
			}

			for (int i = 0; i < vector1.GetDimension(); i++)
			{
				if (vector1.GetElement(i) != vector2.GetElement(i))
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>
		///		Compare two vectors to be not equal.
		/// </summary>
		/// <param name="vector1"></param>
		/// <param name="vector2"></param>
		/// <returns></returns>
		public static bool operator !=(Vector vector1, Vector vector2)
		{
			if (Utils.IsAnyNull(vector1, vector2))
			{
				throw new ArgumentNullException();
			}

			if (vector1.GetDimension() != vector2.GetDimension())
			{
				return true;
			}

			for (int i = 0; i < vector1.GetDimension(); i++)
			{
				if (vector1.GetElement(i) != vector2.GetElement(i))
				{
					return true;
				}
			}
			return false;
		}
		#endregion


		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		// Operations
		#region Operations

		public bool AreLinearDependent(params Vector[] vectors)
		{
			// TODO
			return false;
		}

		/// <summary>
		///		Returns length of vector
		/// </summary>
		/// <returns></returns>
		public decimal GetLength()
		{
			decimal sumSquares = 0;
			foreach (decimal value in this.vector)
			{
				sumSquares += DecimalMath.Pow(value, 2);
			}
			return DecimalMath.Sqrt(sumSquares);
		}

		/// <summary>
		///		Returns sum of multiple vectors
		/// </summary>
		/// <param name="vectors"></param>
		/// <returns></returns>
		public static Vector GetSumOfMultiple(params Vector[] vectors)
		{
			if (Utils.IsAnyNull(vectors))
			{
				throw new ArgumentNullException();
			}

			if (!Vector.AreAllSameDimension(vectors))
			{
				throw new ArgumentException("All vectors need to have same dimension");
			}

			Vector sum = Vector.CreateZeroVector(vectors[0].GetDimension());
			foreach(Vector vector in vectors)
			{
				 sum += vector;
			}

			return sum;
		}

		/// <summary>
		///		Returns difference of multiple vectors
		/// </summary>
		/// <param name="vectors"></param>
		/// <returns></returns>
		public static Vector GetDiffOfMultiple(params Vector[] vectors)
		{
			if (Utils.IsAnyNull(vectors))
			{
				throw new ArgumentNullException();
			}

			if (!Vector.AreAllSameDimension(vectors))
			{
				throw new ArgumentException("All vectors need to have same dimension");
			}

			Vector diff = Vector.CreateVector(vectors[0]);
			for (int i = 1; i < vectors.Length; i++) 
			{
				diff -= vectors[i];
			}

			return diff;
		}

		/// <summary>
		///		Returns unit vector of current vector
		/// </summary>
		/// <returns></returns>
		public Vector GetUnitVector()
		{
			return Vector.CreateVector(this / this.GetLength());
		}

		/// <summary>
		///		Checks if two vectors are antiparallel to each other
		/// </summary>
		/// <param name="vector"></param>
		/// <returns></returns>
		public bool IsAnitParallel(Vector vector)
		{
			if (Utils.IsAnyNull(vector))
			{
				throw new ArgumentNullException();
			}

			if (this.GetDimension() != vector.GetDimension())
			{
				throw new UnevenDimensionException("Vectors");
			}

			if (this.GetDimension() == 1)
			{
				if (this.vector[0] == vector.vector[0])
				{
					return true;
				}
				return false;
			}
			else if (this.GetDimension() > 1)
			{
				decimal k = this.vector[0] / vector.vector[0];
				if (k < 0)
				{
					return false;
				}
				for (int i = 1; i < this.GetDimension(); i++)
				{
					if (this.vector[i] != k * vector.vector[i])
					{
						return false;
					}
				}
				return true;
			}
			else
			{
				throw new InvalidSizeException();
			}
		}

		/// <summary>
		///		Checks if two vectors are inverse to each other
		/// </summary>
		/// <param name="vector"></param>
		/// <returns></returns>
		public bool IsInverse(Vector vector)
		{
			return (this.IsOpposite(vector) && this.GetLength() == vector.GetLength());
		}

		/// <summary>
		///		Checks if two vectors are opposite to each other
		/// </summary>
		/// <param name="vector"></param>
		/// <returns></returns>
		public bool IsOpposite(Vector vector)
		{
			if (Utils.IsAnyNull(vector))
			{
				throw new ArgumentNullException();
			}

			if (this.GetDimension() != vector.GetDimension())
			{
				throw new UnevenDimensionException("Vectors");
			}

			if (this.GetDimension() == 1)
			{
				if (this.vector[0] == vector.vector[0])
				{
					return true;
				}
				return false;
			}
			else if (this.GetDimension() > 1)
			{
				decimal k = this.vector[0] / vector.vector[0];
				if (k > 0)
				{
					return false;
				}
				for (int i = 1; i < this.GetDimension(); i++)
				{
					if (this.vector[i] != k * vector.vector[i])
					{
						return false;
					}
				}
				return true;
			}
			else
			{
				throw new InvalidSizeException();
			}
		}

		/// <summary>
		///		Checks if two vectors are parallel to each other
		/// </summary>
		/// <param name="vector"></param>
		/// <returns></returns>
		public bool IsParallel(Vector vector)
		{
			if (Utils.IsAnyNull(vector))
			{
				throw new ArgumentNullException();
			}

			if (this.GetDimension() != vector.GetDimension())
			{
				throw new UnevenDimensionException("Vectors");
			}

			if (this.GetDimension() == 1) { 
				if (this.vector[0] == vector.vector[0])
				{
					return true;
				}
				return false;
			}
			else if (this.GetDimension() > 1)
			{
				decimal k = this.vector[0] / vector.vector[0];
				for (int i = 1; i < this.GetDimension(); i++)
				{
					if (this.vector[i] != k * vector.vector[i])
					{
						return false;
					}
				}
				return true;
			} 
			else
			{
				throw new InvalidSizeException();
			}
		}
		#endregion


		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		// Methods
		#region Methods
		/// <summary>
		///		Converts Vector into a horizontal matrix where n = n and m = 1
		/// </summary>
		/// <returns></returns>
		public Matrix ConvertToHorizontalMatrix()
		{
			List<List<decimal>> values = new List<List<decimal>>
			{
				this.vector
			};
			return Matrix.CreateMatrix(values);
		}

		/// <summary>
		///		Converts Vector into a vertical matrix where n = 1 and m = n
		/// </summary>
		/// <returns></returns>
		public Matrix ConvertToVerticalMatrix()
		{
			List<List<decimal>> values = new List<List<decimal>>();
			foreach (decimal value in this.vector)
			{
				List<decimal> rowValue = new List<decimal>
				{
					value
				};
				values.Add(rowValue);
			}
			return Matrix.CreateMatrix(values);
		}

		/// <summary>
		///		Checks Equality
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public override bool Equals(object obj)
		{
			return obj is Vector vector &&
				   n == vector.n &&
				   EqualityComparer<List<decimal>>.Default.Equals(this.vector, vector.vector);
		}

		/// <summary>
		///		Returns size of the vector
		/// </summary>
		/// <returns></returns>
		public int GetDimension()
		{
			return this.n;
		}

		/// <summary>
		///		Get value at index
		/// </summary>
		/// <param name="n"></param>
		/// <returns></returns>
		public decimal GetElement(int n)
		{
			if (!Utils.AreValidIndexes(new Tuple<int, int>(n, this.n)))
			{
				throw new IndexOutOfRangeException();
			}
			return this.vector[n];
		}

		/// <summary>
		///		Returns Hash Code
		/// </summary>
		/// <returns></returns>
		public override int GetHashCode()
		{
			var hashCode = 722962651;
			hashCode = hashCode * -1521134295 + n.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<List<decimal>>.Default.GetHashCode(vector);
			return hashCode;
		}

		/// <summary>
		///		Get values of vector as List<decimal>
		/// </summary>
		/// <returns></returns>
		public List<decimal> GetValues()
		{
			return this.vector;
		}

		/// <summary>
		///		Print values of vector in console
		/// </summary>
		public void PrintValues()
		{
			Console.WriteLine("n = " + this.n);

			String line = "";
			for (int i = 0; i < this.n; i++)
			{
				line += this.vector[i] + "\t";
			}
			Console.WriteLine(line);
		}

		/// <summary>
		///		Set value at index
		/// </summary>
		/// <param name="n"></param>
		/// <param name="value"></param>
		public void SetElement(int n, int value)
		{
			if (!Utils.AreValidIndexes(new Tuple<int, int>(n, this.n)))
			{
				throw new IndexOutOfRangeException();
			}
			this.vector[n] = Convert.ToDecimal(value);
		}

		/// <summary>
		///		Set value at index
		/// </summary>
		/// <param name="n"></param>
		/// <param name="value"></param>
		public void SetElement(int n, decimal value)
		{
			if (!Utils.AreValidIndexes(new Tuple<int, int>(n, this.n)))
			{
				throw new IndexOutOfRangeException();
			}
			this.vector[n] = value;
		}

		/// <summary>
		///		Set value at index
		/// </summary>
		/// <param name="n"></param>
		/// <param name="value"></param>
		public void SetElement(int n, float value)
		{
			if (!Utils.AreValidIndexes(new Tuple<int, int>(n, this.n)))
			{
				throw new IndexOutOfRangeException();
			}
			this.vector[n] = Convert.ToDecimal(value);
		}
		#endregion


		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		// Utils
		#region Utils
		/// <summary>
		///		Checks if all given vectors have same dimension
		///		If only one vector was entered the method will return true since all are same dimension
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public static bool AreAllSameDimension(params Vector[] input)
		{
			if (Utils.IsAnyNull(input))
			{
				throw new ArgumentNullException();
			}

			int dimension = -1;
			foreach (Vector vector in input)
			{
				if (dimension == -1)
				{
					dimension = vector.GetDimension();
				}
				else
				{
					if (vector.GetDimension() != dimension)
					{
						return false;
					}
				}
			}
			return true;
		}
		#endregion
	}
}
