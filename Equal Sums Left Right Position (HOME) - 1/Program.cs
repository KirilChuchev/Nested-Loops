using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Sums_Left_Right_Position__HOME____1
{
	class Program
	{
		static void Main(string[] args)
		{
			int number1 = int.Parse(Console.ReadLine());
			int number2 = int.Parse(Console.ReadLine());

			int sumLeft = 0;
			int sumRight = 0;
			int digit1 = 0;
			int digit2 = 0;
			int digit3 = 0;
			int digit4 = 0;
			int digit5 = 0;

			for (int number = number1; number <= number2; number++)
			{
				
				string numberS = $"{number}";

				digit1 = int.Parse(numberS[0].ToString());
				digit2 = int.Parse(numberS[1].ToString());
				digit3 = int.Parse(numberS[2].ToString());
				digit4 = int.Parse(numberS[3].ToString());
				digit5 = int.Parse(numberS[4].ToString());

				sumLeft = digit1 + digit2;
				sumRight = digit4 + digit5;

				if (sumLeft == sumRight)
				{
					Console.Write($"{number} ");
				}
				else if (sumLeft > sumRight)
				{
					sumRight += digit3;
					if (sumLeft == sumRight)
					{
						Console.Write($"{number} ");
					}
				}
				else
				{

					sumLeft += digit3;
					if (sumLeft == sumRight)
					{
						Console.Write($"{number} ");
					}
				}

			}
		}
	}
}
