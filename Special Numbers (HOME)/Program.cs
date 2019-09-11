using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Numbers__HOME_
{
	class Program
	{
		static void Main(string[] args)
		{
			int N = int.Parse(Console.ReadLine());

			int counter = 0;

			for (int number = 1111; number <= 9999; number++)
			{
				string numberS = $"{number}";

				for (int i = 0; i < numberS.Length; i++)
				{
					int digit = int.Parse(numberS[i].ToString());

					if (digit == 0)
					{
						break;
					}
					else if (N % digit == 0)
					{
						counter++;
					}
				}

				if (counter == numberS.Length)
				{
					Console.Write($"{number} ");
				}

				counter = 0;
			}
		}
	}
}
