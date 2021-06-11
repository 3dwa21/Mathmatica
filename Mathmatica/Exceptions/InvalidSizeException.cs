using System;

namespace Mathmatica.Exceptions
{
	[Serializable]
	public class InvalidSizeException : Exception
	{
		public InvalidSizeException()
			: base("Size must be 1 or greater") { }

		public InvalidSizeException(int minSize)
			: base(String.Format("Size must be {0} or greater", minSize)) { }
	}
}
