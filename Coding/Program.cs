using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			string numberAsString = "" + n;

			int rows = numberAsString.Length;

			for (int i = 0; i < rows; i++)
			{
				int number = int.Parse(numberAsString[numberAsString.Length - i - 1] + "");

				if (number == 0)
				{
					Console.WriteLine("ZERO");
					continue;
				}

				for (int j = 0; j < number; j++)
				{
					Console.Write((char)(number + 33));
					
				}

				Console.WriteLine();



			}

		}
	}
}
