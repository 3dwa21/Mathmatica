using System;

namespace Mathmatica
{
	public static class Utils
	{
		/// <summary>
		/// Checks if any Indexes are outside of the boundary
		/// Parameters have to be inserted in Tuples. First item contains the questioned index while the second contains the size of the List/Array/Matrix/...
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public static bool AreValidIndexes(params Tuple<int, int>[] input)
		{
			for (int i = 0; i < input.Length; i++)
			{
				if (input[i].Item1 < 0 || input[i].Item1 > input[i].Item2)
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>
		/// Checks if any of multiple inputs is null object
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="input"></param>
		/// <returns></returns>
		public static bool IsAnyNull<T> (params T[] input ) where T : class
		{
			foreach (T obj in input)
			{
				if (obj is null)
				{
					return true;
				}
			}
			return false;
		}
	}
}
