using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix__HOME_
{
	class Program
	{
		static void Main(string[] args)
		{

			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			int c = int.Parse(Console.ReadLine());
			int d = int.Parse(Console.ReadLine());

			for (int number1 = a; number1 <= b; number1++)
			{
				for (int number2 = a; number2 <= b; number2++)
				{
					for (int number3 = c; number3 <= d; number3++)
					{
						for (int number4 = c; number4 <= d; number4++)
						{
							if ((number1 + number4) == (number2 + number3) && number1 != number2 && number3 != number4)
							{
								Console.WriteLine($"{number1}{number2}");
								Console.WriteLine($"{number3}{number4}");
								Console.WriteLine();
							}
						}
					}
				}
			}
		}
	}
}
