using Mathmatica;
using Mathmatica.Core;
using System;
using System.Collections.Generic;

namespace Mathematica_Test
{
	class Program
	{
		static void Main(string[] args)
		{
			List<List<decimal>> values = new List<List<decimal>>();
			List<decimal> row1 = new List<decimal>();
			row1.Add(1);
			row1.Add(2);
			row1.Add(3);
			List<decimal> row2 = new List<decimal>();
			row2.Add(4);
			row2.Add(5);
			row2.Add(6);
			List<decimal> row3 = new List<decimal>();
			row3.Add(7);
			row3.Add(8);
			row3.Add(9);
			values.Add(row1);
			//values.Add(row2);
			//values.Add(row3);

			new ComplexNumber(5, -2).PrintValues();


			//////////////////////////////////////////////
			// Stop before end							//
			Console.ReadKey();							//
			//////////////////////////////////////////////
		}
	}
}
