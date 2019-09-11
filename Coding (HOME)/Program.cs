using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding__HOME_
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());

			string numberS = $"{number}";

			int rows = numberS.Length;
			int digit = numberS.Length - 1;
			int columns = 0;

			for (int currentRow = rows-1; currentRow >= 0; currentRow--)
			{

				//columns = (int)(numberS[currentRow]) - 48;

				columns = int.Parse(numberS[currentRow].ToString());

				if (columns == 0)
				{
					Console.WriteLine("ZERO");
					continue;
				}
				

				for (int i = 1; i <= columns; i++)
				{
					char charDigit = (char)(columns + 33);
					Console.Write(charDigit);
				}
				Console.WriteLine();
			}

			
		}
	}
}
