using System;

namespace Mathmatica.Exceptions
{
	[Serializable]
	public class InvalidDimensionException : Exception
	{
		public InvalidDimensionException()
			: base("Dimension must be 1 or greater") { }

		public InvalidDimensionException(int minDimension)
			: base(String.Format("Dimension must be {0} or greater", minDimension)) { }
	}
}
