using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Sums_Left_Right_Position__HOME_
{
	class Program
	{
		static void Main(string[] args)
		{

			int number1 = int.Parse(Console.ReadLine());
			int number2 = int.Parse(Console.ReadLine());

			for (int number = number1; number <= number2; number++)
			{
				int sumLeft = 0;
				int sumRight = 0;
				int digit = 0;

				string numberS = $"{number}";
				int numberLength = numberS.Length;

				for (int i = 1; i <= numberLength; i++)
				{
					digit = int.Parse(numberS[i - 1].ToString());

					if (i == 1 || i == 2)
					{
						sumLeft += digit;
					}
					else if (i == 4 || i == 5)
					{
						sumRight += digit;
					}
				}

				if (sumLeft == sumRight)
				{
					Console.Write($"{number} ");
				}
				else
				{
					if (sumLeft > sumRight)
					{
						digit = int.Parse(numberS[2].ToString());
						sumRight += digit;
					}
					else
					{
						digit = int.Parse(numberS[2].ToString());
						sumLeft += digit;
					}

					if (sumLeft == sumRight)
					{
						Console.Write($"{number} ");
					}
				}
			}
		}
	}
}
