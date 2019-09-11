using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Sums_Even_Odd_Position__HOME_
{
	class Program
	{
		static void Main(string[] args)
		{
			int number1 = int.Parse(Console.ReadLine());
			int number2 = int.Parse(Console.ReadLine());

			

			for (int i = number1; i <= number2; i++)
			{
				int sumEven = 0;
				int sumOdd = 0;

				string number = $"{i}";
				int numberLength = number.Length;

				for (int digitPossition = 1; digitPossition <= numberLength; digitPossition++)
				{
					int digit = int.Parse(number[digitPossition-1].ToString());

					if (digitPossition % 2 == 0)
					{
						sumEven += digit;
					}
					else
					{
						sumOdd += digit;
					}
				}

				if (sumEven == sumOdd)
				{
					Console.Write($"{number} ");
				}
			}
		}
	}
}
