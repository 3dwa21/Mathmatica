using Mathmatica.Exceptions;
using Mathmatica.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mathmatica
{
	public class Matrix : IMatrix
	{
		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		/// Parameters
		/// 
		private int n = 0;	// Columns
		private int m = 0;  // Rows

		public List<List<decimal>> matrix;


		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		// Constructor Management
		#region Constructor Management
		/// <summary>
		///		Create an Identity Matrix with size n
		/// </summary>
		/// <param name="n"></param>
		/// <returns></returns>
		public static Matrix CreateIdentityMatrix(int n)
		{
			if (n <= 0)
			{
				throw new InvalidSizeException();
			}

			List<List<decimal>> identityMatrix = new List<List<decimal>>();
			for (int i = 0; i < n; i++)
			{
				List<decimal> line = new List<decimal>();
				for (int j = 0; j < n; j++)
				{
					if (i == j)
					{
						line.Add(1);
					}
					else {
						line.Add(0);
					}
				}
				identityMatrix.Add(line);
			}

			return new Matrix(identityMatrix);
		}

		/// <summary>
		///		Create a copy of the handed matrix
		/// </summary>
		/// <param name="matrix"></param>
		/// <returns></returns>
		public static Matrix CreateMatrix(Matrix matrix)
		{
			return new Matrix(matrix.GetValues());
		}

		/// <summary>
		///		Create new matrix with handed int values
		/// </summary>
		/// <param name="values"></param>
		/// <returns></returns>
		public static Matrix CreateMatrix(List<List<int>> values)
		{
			if (values.Any())
			{
				if (values[0].Any())
				{
					List<List<decimal>> convertedValues = new List<List<decimal>>();

					for (int j = 0; j < values.Count; j++)
					{
						List<decimal> decimals = values[j].Select<int, decimal>(i => i).ToList();
						convertedValues.Add(decimals);
					}

					return new Matrix(convertedValues);
				}
			}

			throw new InvalidSizeException();
		}

		/// <summary>
		///		Create new matrix with handed decimal values
		/// </summary>
		/// <param name="values"></param>
		/// <returns></returns>
		public static Matrix CreateMatrix(List<List<decimal>> values)
		{
			if (values.Any())
			{
				if(values[0].Any())
				{
					return new Matrix(values);
				}
			}

			throw new InvalidSizeException();
		}

		/// <summary>
		///		Create new matrix with handed double values
		/// </summary>
		/// <param name="values"></param>
		/// <returns></returns>
		public static Matrix CreateMatrix(List<List<double>> values)
		{
			if (values.Count > 0)
			{
				if (values[0].Count > 0)
				{
					List<List<decimal>> convetredValues = new List<List<decimal>>();
					for (int i = 0; i < values.Count; i++)
					{
						List<decimal> line = new List<decimal>();
						for (int j = 0; j < line.Count; j++)
						{
							line.Add(Convert.ToDecimal(values[i][j]));
						}
						convetredValues.Add(line);
					}

					return new Matrix(convetredValues);
				}
			}

			throw new InvalidSizeException();
		}

		/// <summary>
		///		Create new matrix with handed float values
		/// </summary>
		/// <param name="values"></param>
		/// <returns></returns>
		public static Matrix CreateMatrix(List<List<float>> values)
		{
			if (values.Any())
			{
				if (values[0].Any())
				{
					List<List<decimal>> convertedValues = new List<List<decimal>>();

					for (int j = 0; j < values.Count; j++)
					{
						List<decimal> decimals = new List<decimal>();

						foreach (var value in values[j])
						{
							decimals.Add(Convert.ToDecimal(value));
						}

						convertedValues.Add(decimals);
					}

					return new Matrix(convertedValues);
				}
			}

			throw new InvalidSizeException();
		}

		/// <summary>
		///		Create new matrix with handed int values
		/// </summary>
		/// <param name="values"></param>
		/// <returns></returns>
		public static Matrix CreateMatrix(int[][] values)
		{
			if (values.Length > 0)
			{
				if (values[0].Length > 0)
				{
					List<List<decimal>> convetredValues = new List<List<decimal>>();

					for (int i = 0; i < values.Length; i++)
					{
						List<decimal> line = new List<decimal>();
						for (int j = 0; j < values[i].Length; j++)
						{
							line.Add(values[i][j]);
						}
						convetredValues.Add(line);
					}

					return new Matrix(convetredValues);
				}
			}

			throw new InvalidSizeException();
		}

		/// <summary>
		///		Create new matrix with handed decimal values
		/// </summary>
		/// <param name="values"></param>
		/// <returns></returns>
		public static Matrix CreateMatrix(decimal[][] values)
		{
			if (values.Length > 0)
			{
				if (values[0].Length > 0)
				{
					List<List<decimal>> convetredValues = new List<List<decimal>>();
					for (int i = 0; i < values.Length; i++)
					{
						List<decimal> line = new List<decimal>();
						for (int j = 0; j < values[i].Length; j++)
						{
							line.Add(values[i][j]);
						}
						convetredValues.Add(line);
					}

					return new Matrix(convetredValues);
				}
			}

			throw new InvalidSizeException();
		}

		/// <summary>
		///		Create new matrix with handed double values
		/// </summary>
		/// <param name="values"></param>
		/// <returns></returns>
		public static Matrix CreateMatrix(double[][] values)
		{
			if (values.Length > 0)
			{
				if (values[0].Length > 0)
				{
					List<List<decimal>> convetredValues = new List<List<decimal>>();
					for (int i = 0; i < values.Length; i++)
					{
						List<decimal> line = new List<decimal>();
						for (int j = 0; j < values[i].Length; j++)
						{
							line.Add(Convert.ToDecimal(values[i][j]));
						}
						convetredValues.Add(line);
					}

					return new Matrix(convetredValues);
				}
			}

			throw new InvalidSizeException();
		}

		/// <summary>
		///		Create new matrix with handed float values
		/// </summary>
		/// <param name="values"></param>
		/// <returns></returns>
		public static Matrix CreateMatrix(float[][] values)
		{
			if (values.Length > 0)
			{
				if (values[0].Length > 0)
				{
					List<List<decimal>> convetredValues = new List<List<decimal>>();
					for (int i = 0; i < values.Length; i++)
					{
						List<decimal> line = new List<decimal>();
						for (int j = 0; j < values[i].Length; j++)
						{
							line.Add(Convert.ToDecimal(values[i][j]));
						}
						convetredValues.Add(line);
					}

					return new Matrix(convetredValues);
				}
			}

			throw new InvalidSizeException();
		}

		/// <summary>
		///		Create a scalar Matrix with size n and handed values on main diagonale
		/// </summary>
		/// <param name="n"></param>
		/// <param name="scalar"></param>
		/// <returns></returns>
		public static Matrix CreateScalarMatrix(int n, decimal scalar)
		{
			if (n <= 0)
			{
				throw new InvalidSizeException();
			}

			Matrix identityMatrix = Mathmatica.Matrix.CreateIdentityMatrix(n);
			return identityMatrix * scalar;
		}

		/// <summary>
		///		Create an empty (n x m)-Matrix.
		///		Exception will be thrown if n or m are equal to or smaller than 0.
		/// </summary>
		/// <param name="n"></param>
		/// <param name="m"></param>
		/// <returns></returns>
		public static Matrix CreateZeroMatrix(int n, int m)
		{
			if ((n <= 0) || (m <= 0))
			{
				throw new InvalidSizeException();
			}
			return new Matrix(n, m);
		}

		/// <summary>
		///		Create an empty (n x n)-Matrix.
		///		Exception will be thrown if n is equal to or smaller than 0.
		/// </summary>
		/// <param name="n"></param>
		/// <returns></returns>
		public static Matrix CreateZeroMatrix(int n)
		{
			if (n <= 0)
			{
				throw new InvalidSizeException();
			}
			return new Matrix(n, n);
		}
		#endregion


		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		// Constructors
		#region Constructors
		/// <summary>
		///		Constructor for empty Matrix.
		/// </summary>
		/// <param name="n"></param>
		/// <param name="m"></param>
		private Matrix(int n, int m)
		{
			this.n = n;
			this.m = m;

			List<decimal> line = Enumerable.Repeat(0m, n).ToList();
			this.matrix = Enumerable.Repeat(line, m).ToList();
		}

		/// <summary>
		///		Cronstrctor for Matrix with given values
		/// </summary>
		/// <param name="n"></param>
		/// <param name="m"></param>
		/// <param name="values"></param>
		private Matrix(List<List<decimal>> values)
		{
			this.n = values[0].Count;
			this.m = values.Count;
			this.matrix = values;
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
		///		Adding two matrices together.
		/// </summary>
		/// <param name="matrix1"></param>
		/// <param name="matrix2"></param>
		/// <returns></returns>
		public static Matrix operator+ (Matrix matrix1, Matrix matrix2)
		{
			if (Utils.IsAnyNull(matrix1, matrix2))
			{
				throw new ArgumentNullException();
			}

			if ((matrix1.GetNumberOfColumns() != matrix2.GetNumberOfColumns()) || (matrix1.GetNumberOfRows() != matrix2.GetNumberOfRows()))
			{
				throw new UnevenDimensionException("Matrices");
			}

			List<List<decimal>> sum = new List<List<decimal>>();
			List<List<decimal>> values1 = matrix1.GetValues();
			List<List<decimal>> values2 = matrix2.GetValues();

			int n = matrix1.GetNumberOfColumns();
			int m = matrix1.GetNumberOfRows();

			for (int i = 0; i < m; i++)
			{
				List<decimal> line = new List<decimal>();
				for (int j = 0; j < n; j++)
				{
					line.Add(values1[i][j] + values2[i][j]);
				}
				sum.Add(line);
			}

			return Mathmatica.Matrix.CreateMatrix(sum);
		}

		/// <summary>
		///		Subtracting two matrices together.
		/// </summary>
		/// <param name="matrix1"></param>
		/// <param name="matrix2"></param>
		/// <returns></returns>
		public static Matrix operator- (Matrix matrix1, Matrix matrix2)
		{
			if (Utils.IsAnyNull(matrix1, matrix2))
			{
				throw new ArgumentNullException();
			}

			if ((matrix1.GetNumberOfColumns() != matrix2.GetNumberOfColumns()) || (matrix1.GetNumberOfRows() != matrix2.GetNumberOfRows()))
			{
				throw new UnevenDimensionException("Matrices");
			}

			List<List<decimal>> diff = new List<List<decimal>>();
			List<List<decimal>> values1 = matrix1.GetValues();
			List<List<decimal>> values2 = matrix2.GetValues();

			int n = matrix1.GetNumberOfColumns();
			int m = matrix1.GetNumberOfRows();

			for (int i = 0; i < m; i++)
			{
				List<decimal> line = new List<decimal>();
				for (int j = 0; j < n; j++)
				{
					line.Add(values1[i][j] - values2[i][j]);
				}
				diff.Add(line);
			}

			return Mathmatica.Matrix.CreateMatrix(diff);
		}

		/// <summary>
		///		Multily two matrices
		/// </summary>
		/// <param name="matrix1"></param>
		/// <param name="matrix2"></param>
		/// <returns></returns>
		public static Matrix operator* (Matrix matrix1, Matrix matrix2)
		{
			if (Utils.IsAnyNull(matrix1, matrix2))
			{
				throw new ArgumentNullException();
			}

			if (matrix1.GetNumberOfRows() != matrix2.GetNumberOfColumns())
			{
				throw new UnevenDimensionException("Matrices");
			}

			List<List<decimal>> product = new List<List<decimal>>();
			List<List<decimal>> values1 = matrix1.GetValues();
			List<List<decimal>> values2 = matrix2.GetValues();

			int n1 = matrix1.GetNumberOfColumns();
			int m1 = matrix1.GetNumberOfRows();
			int n2 = matrix2.GetNumberOfColumns();

			for (int i = 0; i < m1; i++)
			{
				List<decimal> line = new List<decimal>();
				for (int j = 0; j < n2; j++)
				{
					decimal dotProduct = 0;
					for (int k = 0; k < n1; k++)
					{
						dotProduct += values1[i][k] * values2[k][j];
					}
					line.Add(dotProduct);
				}
				product.Add(line);
			}

			return Mathmatica.Matrix.CreateMatrix(product);
		}

		/// <summary>
		///		Multiply matrix with scalar
		/// </summary>
		/// <param name="matrix"></param>
		/// <param name="scalar"></param>
		/// <returns></returns>
		public static Matrix operator* (Matrix matrix, decimal scalar)
		{
			if (Utils.IsAnyNull(matrix))
			{
				throw new ArgumentNullException();
			}

			int n = matrix.GetNumberOfColumns();
			int m = matrix.GetNumberOfRows();
			List<List<decimal>> values = matrix.GetValues();
			List<List<decimal>> product = new List<List<decimal>>();

			for (int i = 0; i < m; i++)
			{
				List<decimal> line = new List<decimal>();
				for (int j = 0; j < n; j++)
				{
					line.Add(values[i][j] * scalar);
				}
				product.Add(line);
			}

			return Mathmatica.Matrix.CreateMatrix(product);
		}

		/// <summary>
		///		Divide matrix with scalar
		/// </summary>
		/// <param name="matrix"></param>
		/// <param name="scalar"></param>
		/// <returns></returns>
		public static Matrix operator/ (Matrix matrix, decimal scalar)
		{
			if (Utils.IsAnyNull(matrix))
			{
				throw new ArgumentNullException();
			}

			int n = matrix.GetNumberOfColumns();
			int m = matrix.GetNumberOfRows();
			List<List<decimal>> values = matrix.GetValues();
			List<List<decimal>> quotient = new List<List<decimal>>();

			for (int i = 0; i < m; i++)
			{
				List<decimal> line = new List<decimal>();
				for (int j = 0; j < n; j++)
				{
					line.Add(values[i][j] / scalar);
				}
				quotient.Add(line);
			}

			return Mathmatica.Matrix.CreateMatrix(quotient);
		}

		/// <summary>
		///		Compare two matrices to be equal.
		/// </summary>
		/// <param name="matrix1"></param>
		/// <param name="matrix2"></param>
		/// <returns></returns>
		public static bool operator== (Matrix matrix1, Matrix matrix2)
		{
			if (Utils.IsAnyNull(matrix1, matrix2))
			{
				throw new ArgumentNullException();
			}

			if ((matrix1.GetNumberOfColumns() != matrix2.GetNumberOfColumns()) || (matrix1.GetNumberOfRows() != matrix2.GetNumberOfRows()))
			{
				return false;
			}

			for (int i = 0; i < matrix1.GetNumberOfRows(); i++)
			{
				for (int j = 0; j < matrix1.GetNumberOfColumns(); j++)
				{
					if (matrix1.GetElement(i, j) != matrix2.GetElement(i, j))
					{
						return false;
					}
				}
			}
			return true;
		}

		/// <summary>
		///		Compare two matrices to be not equal.
		/// </summary>
		/// <param name="matrix1"></param>
		/// <param name="matrix2"></param>
		/// <returns></returns>
		public static bool operator!= (Matrix matrix1, Matrix matrix2)
		{
			if (Utils.IsAnyNull(matrix1, matrix2))
			{
				throw new ArgumentNullException();
			}

			if ((matrix1.GetNumberOfColumns() != matrix2.GetNumberOfColumns()) || (matrix1.GetNumberOfRows() != matrix2.GetNumberOfRows()))
			{
				return true;
			}

			for (int i = 0; i < matrix1.GetNumberOfRows(); i++)
			{
				for (int j = 0; j < matrix1.GetNumberOfColumns(); j++)
				{
					if (matrix1.GetElement(i, j) != matrix2.GetElement(i, j))
					{
						return true;
					}
				}
			}
			return false;
		}
		#endregion


		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		// Operations
		#region Operations
		/// <summary>
		///		Calculates the determinant of the matrix.
		/// </summary>
		/// <returns></returns>
		public decimal GetDeterminant()
		{
			if (!this.IsSquare())
			{
				throw new InvalidDimensionException();
			}

			decimal determinant = 0;
			if (this.IsTriangularLower() || this.IsTriangularUpper())
			{
				for (int i = 0; i < this.m; i++)
				{
					determinant *= this.matrix[i][i];
				}
				return determinant;
			}

			return 0; // TODO normal determinant
		}

		/// <summary>
		///		Returns skew symmetric matrix
		/// </summary>
		/// <returns></returns>
		public Matrix GetSkewSymmetricMatrix()
		{
			if (this.IsSquare())
			{
				return (this - this.GetTranspose()) * 0.5m;
			}
			throw new InvalidDimensionException();
		}

		/// <summary>
		///		Returns sum of multiple matrices
		/// </summary>
		/// <param name="matrices"></param>
		/// <returns></returns>
		public static Matrix GetSumOfMultiple(params Matrix[] matrices)
		{
			if (Utils.IsAnyNull(matrices))
			{
				throw new ArgumentNullException();
			}

			if (!Matrix.AreAllSameDimension(matrices))
			{
				throw new ArgumentException("All matrices need to have same dimension");
			}

			Matrix sum = Matrix.CreateZeroMatrix(matrices[0].GetNumberOfColumns(), matrices[0].GetNumberOfRows());
			foreach (Matrix matrix in matrices)
			{
				sum += matrix;
			}

			return sum;
		}

		/// <summary>
		///		Returns difference of multiple matrices
		/// </summary>
		/// <param name="matrices"></param>
		/// <returns></returns>
		public static Matrix GetDiffOfMultiple(params Matrix[] matrices)
		{
			if (Utils.IsAnyNull(matrices))
			{
				throw new ArgumentNullException();
			}

			if (!Matrix.AreAllSameDimension(matrices))
			{
				throw new ArgumentException("All matrices need to have same dimension");
			}

			Matrix diff = Matrix.CreateMatrix(matrices[0]);
			for (int i = 1; i < matrices.Length; i++)
			{
				diff -= matrices[i];
			}

			return diff;
		}

		/// <summary>
		///		Returns symmetric matrix
		/// </summary>
		/// <returns></returns>
		public Matrix GetSymmetricMatrix()
		{
			if (this.IsSquare()) {
				return (this + this.GetTranspose()) * 0.5m;
			}
			throw new InvalidDimensionException();
		}

		/// <summary>
		///		Get the summarized value of the matrix main-diagonal.
		///		Matrix must be (n x n) otherwhise NaN will be returned.
		/// </summary>
		/// <returns></returns>
		public decimal GetTrace()
		{
			if (this.IsSquare())
			{
				decimal trace = 0;
				for (int i = 0; i < this.n; i++)
				{
					trace += matrix[i][i];
				}
				return trace;
			}
			throw new InvalidDimensionException();
		}

		/// <summary>
		///		returns transposed matrix.
		/// </summary>
		public Matrix GetTranspose()
		{
			List<List<decimal>> transposedMatrix = new List<List<decimal>>();

			for (int i = 0; i < this.n; i++)
			{
				List<decimal> line = new List<decimal>();
				for (int j = 0; j < this.m; j++)
				{
					line.Add(this.matrix[j][i]);
				}
				transposedMatrix.Add(line);
			}

			return Mathmatica.Matrix.CreateMatrix(transposedMatrix);
		}

		/// <summary>
		///		Determines whether a matrix is an band matrix
		/// </summary>
		/// <returns></returns>
		public bool IsBandMatrix()
		{
			if (!this.IsSquare())
			{
				return false;
			}

			for (int k = 1; k < this.m; k++) {
				bool isBandMatrix = true;

				for (int i = k; i < this.m; i++)
				{
					for (int j = 0; j < (i - 1); j++)
					{
						if (this.matrix[i][j] != 0)
						{
							isBandMatrix = false;
						}
					}
				}

				for (int i = 0; i < this.m; i++)
				{
					for (int j = i + k; j < this.n; j++)
					{
						if (this.matrix[i][j] != 0)
						{
							isBandMatrix = false;
						}
					}
				}

				if (isBandMatrix)
				{
					return true;
				}
			}

			return false;
		}

		/// <summary>
		///		Determines whether a matrix is a diagonal matrix or not
		/// </summary>
		/// <returns></returns>
		public bool IsDiagonal()
		{
			if (this.IsTriangularLower() && this.IsTriangularUpper())
			{
				return true;
			}
			return false;
		}

		/// <summary>
		///		Determines if matrix is an upper matrix
		/// </summary>
		/// <returns></returns>
		public bool IsHessenbergUpper()
		{
			if (!this.IsSquare())
			{
				return false;
			}

			for (int i = 2; i < this.m; i++)
			{
				for (int j = 0; j < (i - 1); j++)
				{
					if (this.matrix[i][j] != 0)
					{
						return false;
					}
				}
			}

			return true;
		}

		/// <summary>
		///		Determines if matrix is an lower matrix
		/// </summary>
		/// <returns></returns>
		public bool IsHessenbergLower()
		{
			if (!this.IsSquare())
			{
				return false;
			}

			for (int i = 0; i < this.m; i++)
			{
				for (int j = i + 2; j < this.n; j++)
				{
					if (this.matrix[i][j] != 0)
					{
						return false;
					}
				}
			}

			return true;
		}

		/// <summary>
		///		Determines whether a matrix is skew symmetric or not
		/// </summary>
		/// <returns></returns>
		public bool IsSkewSymmetric()
		{
			if (this.IsSquare())
			{
				for (int i = 1; i < m; i++)
				{
					for (int j = 0; j < i; j++)
					{
						if (this.matrix[i][j] != -this.matrix[j][i])
						{
							return false;
						}
					}
				}
				return true;
			}
			return false;
		}

		/// <summary>
		///		Determines whether n = m aka. matix is square or not.
		/// </summary>
		/// <returns></returns>
		public bool IsSquare()
		{
			if (this.n == this.m)
			{
				return true;
			}
			return false;
		}

		/// <summary>
		///		Determines whether a matrix is symmetric or not
		/// </summary>
		/// <returns></returns>
		public bool IsSymmetric()
		{
			if (this.IsSquare())
			{
				for (int i = 1; i < m; i++)
				{
					for (int j = 0; j < i; j++)
					{
						if (this.matrix[i][j] != this.matrix[j][i])
						{
							return false;
						}
					}
				}
				return true;
			}
			return false;
		}

		/// <summary>
		///		Determines if matrix is an upper matrix
		/// </summary>
		/// <returns></returns>
		public bool IsTriangularUpper()
		{
			if (!this.IsSquare()) 
			{
				return false;
			}

			for (int i = 1; i < this.m; i++)
			{
				for (int j = 0; j < i; j++)
				{
					if (this.matrix[i][j] != 0)
					{
						return false;
					}
				}
			}

			return true;
		}

		/// <summary>
		///		Determines if matrix is an lower matrix
		/// </summary>
		/// <returns></returns>
		public bool IsTriangularLower()
		{
			if (!this.IsSquare())
			{
				return false;
			}

			for (int i = 0; i < this.m; i++)
			{
				for (int j = i + 1; j < this.n; j++)
				{
					if (this.matrix[i][j] != 0)
					{
						return false;
					}
				}
			}

			return true;
		}

		/// <summary>
		///		Determines whether a Matrix is tri-diagonal
		/// </summary>
		/// <returns></returns>
		public bool IsTriDiagonal()
		{
			if (this.IsHessenbergLower() && this.IsHessenbergUpper())
			{
				return true;
			}
			return false;
		}

		/// <summary>
		///		Transposes this matrix
		/// </summary>
		public void Transpose()
		{
			Matrix matrix = this.GetTranspose();
			this.matrix = matrix.GetValues();
			this.n = matrix.GetNumberOfColumns();
			this.m = matrix.GetNumberOfRows();
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
			return obj is Matrix matrix &&
				   n == matrix.n &&
				   m == matrix.m &&
				   EqualityComparer<List<List<decimal>>>.Default.Equals(this.matrix, matrix.matrix);
		}

		/// <summary>
		///		Returns single column of matrix at index i
		/// </summary>
		/// <param name="i"></param>
		/// <returns></returns>
		public List<decimal> GetColumn(int i)
		{
			if (!Utils.AreValidIndexes(new Tuple<int, int>(i, this.n)))
			{
				throw new IndexOutOfRangeException();
			}

			List<decimal> column = new List<decimal>();
			foreach(List<decimal> row in this.matrix)
			{
				column.Add(row[i]);
			}
			return column;
		}

		/// <summary>
		///		Returns single column of matrix at index i
		/// </summary>
		/// <param name="i"></param>
		/// <returns></returns>
		public Vector GetColumnVector(int i)
		{
			return Vector.CreateVector(this.GetColumn(i));
		}

		/// <summary>
		///		Returns value at handed position where as n determines the row and m the column.
		/// </summary>
		/// <param name="n"></param>
		/// <param name="m"></param>
		/// <returns></returns>
		public decimal GetElement(int n, int m)
		{
			if (!Utils.AreValidIndexes(new Tuple<int, int>(n, this.n), new Tuple<int, int>(m, this.m)))
			{
				throw new IndexOutOfRangeException();
			}

			return this.matrix[n][m];
		}

		/// <summary>
		///		Returns Hash Code
		/// </summary>
		/// <returns></returns>
		public override int GetHashCode()
		{
			var hashCode = -1686816027;
			hashCode = hashCode * -1521134295 + n.GetHashCode();
			hashCode = hashCode * -1521134295 + m.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<List<List<decimal>>>.Default.GetHashCode(matrix);
			return hashCode;
		}

		/// <summary>
		///		Returns the number of columns of the matrix
		/// </summary>
		/// <returns></returns>
		public int GetNumberOfColumns()
		{
			return this.n;
		}

		/// <summary>
		///		Returns the number of rows of the matrix
		/// </summary>
		/// <returns></returns>
		public int GetNumberOfRows()
		{
			return this.m;
		}

		/// <summary>
		///		Returns single row of matrix at index i
		/// </summary>
		/// <param name="i"></param>
		/// <returns></returns>
		public List<decimal> GetRow(int i)
		{
			if (!Utils.AreValidIndexes(new Tuple<int, int>(i, this.m)))
			{
				throw new IndexOutOfRangeException();
			}

			return this.matrix[i];
		}

		/// <summary>
		///		Returns single row of matrix at index i
		/// </summary>
		/// <param name="i"></param>
		/// <returns></returns>
		public Vector GetRowVector(int i)
		{
			return Vector.CreateVector(this.GetRow(i));
		}

		/// <summary>
		///		Get the matrix' values as Lists within List containing decimals.
		/// </summary>
		/// <returns></returns>
		public List<List<decimal>> GetValues()
		{
			return this.matrix;
		}

		/// <summary>
		///		Print values of matrix in console
		/// </summary>
		public void PrintValues()
		{
			Console.WriteLine("n = " + this.n);
			Console.WriteLine("m = " + this.m);

			for (int i = 0; i < this.m; i++)
			{
				String line = "";
				for (int j = 0; j < this.n; j++)
				{
					line += this.matrix[i][j] + "\t";
				}
				Console.WriteLine(line);
			}
		}

		/// <summary>
		///		Sets int value at handed position where as i determines the row and j the column.
		/// </summary>
		/// <param name="n"></param>
		/// <param name="m"></param>
		/// <param name="value"></param>
		public void SetElement(int n, int m, int value)
		{
			if (!Utils.AreValidIndexes(new Tuple<int, int>(n, this.n), new Tuple<int, int>(m, this.m)))
			{
				throw new IndexOutOfRangeException();
			}

			this.matrix[n][m] = Convert.ToDecimal(value);
		}

		/// <summary>
		///		Sets decimal value at handed position where as i determines the row and j the column.
		/// </summary>
		/// <param name="n"></param>
		/// <param name="m"></param>
		/// <param name="value"></param>
		public void SetElement(int n, int m, decimal value)
		{
			if (!Utils.AreValidIndexes(new Tuple<int, int>(n, this.n), new Tuple<int, int>(m, this.m)))
			{
				throw new IndexOutOfRangeException();
			}

			this.matrix[n][m] = value;
		}

		/// <summary>
		///		Sets float value at handed position where as i determines the row and j the column.
		/// </summary>
		/// <param name="n"></param>
		/// <param name="m"></param>
		/// <param name="value"></param>
		public void SetElement(int n, int m, float value)
		{
			if (!Utils.AreValidIndexes(new Tuple<int, int>(n, this.n), new Tuple<int, int>(m, this.m)))
			{
				throw new IndexOutOfRangeException();
			}

			this.matrix[n][m] = Convert.ToDecimal(value);
		}
		#endregion


		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		// Utils
		#region Utils
		/// <summary>
		///		Checks if all given matrices have same dimension
		///		If only one matrix was entered the method will return true since all are same dimension
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public static bool AreAllSameDimension(params Matrix[] input)
		{
			if (Utils.IsAnyNull(input))
			{
				throw new ArgumentNullException();
			}

			int dimensionN = -1;
			int dimensionM = -1;
			foreach (Matrix matrix in input)
			{
				if (dimensionM == -1 && dimensionN == -1)
				{
					dimensionN = matrix.n;
					dimensionM = matrix.m;
				}
				else
				{
					if (matrix.GetNumberOfRows() != dimensionM || matrix.GetNumberOfColumns() != dimensionN)
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
