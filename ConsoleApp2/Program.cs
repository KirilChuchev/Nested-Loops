using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int number = 1;

			for (int rows = -5; rows <= n; rows++) // няма значение колко пъти ще върти цикъла понеже всеки път ще прекъсне когато свършат числата.
			{
				for (int columns = -5; columns <= rows; columns++)
				{
					if (number > n)
					{
						break;
					}
					else
					{
						Console.Write($"{number} ");
						number++;
					}

				}
				Console.WriteLine();
			}
		}
	}
}
