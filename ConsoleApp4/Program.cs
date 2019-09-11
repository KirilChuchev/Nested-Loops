using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
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
				int currentNumber = number;

				digit5 = currentNumber % 10;
				currentNumber /= 10;
				digit4 = currentNumber % 10;
				currentNumber /= 10;
				digit3 = currentNumber % 10;
				currentNumber /= 10;
				digit2 = currentNumber % 10;
				digit1 = currentNumber /= 10;



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
