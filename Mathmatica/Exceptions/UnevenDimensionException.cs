using System;

namespace Mathmatica.Exceptions
{
	[Serializable]
	public class UnevenDimensionException : Exception
	{
        public UnevenDimensionException(String obj)
            : base(String.Format("Cannot process 2 {0} with different dimensions", obj)) { }
    }
}
