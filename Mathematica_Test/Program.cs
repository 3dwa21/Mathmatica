using Mathmatica;
using System;
using System.Collections.Generic;

namespace Mathematica_Test
{
	class Program
	{
		static void Main(string[] args)
		{
			Vector baseV = Vector.CreateVector(1.23456789m, 9.87654321m);
			Vector vector = Vector.CreateVector(-1.23456789m, -9.87654321m);

			Console.WriteLine(baseV.IsParallel(vector));

			//////////////////////////////////////////////
			// Stop before end							//
			Console.ReadKey();							//
			//////////////////////////////////////////////
		}
	}
}
