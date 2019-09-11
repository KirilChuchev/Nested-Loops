using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	class Program
	{
		static void Main(string[] args)
		{
			/*

			char a = '4';
			//int n = (int)a - 48;

			int n = int.Parse(a.ToString());
			Console.WriteLine(n);

	*/

			int currentNumber = int.Parse(Console.ReadLine());

			int digit1 = 0;
			int digit2 = 0;
			int digit3 = 0;
			int digit4 = 0;
			int digit5 = 0;

			digit5 = currentNumber % 10;
			currentNumber /= 10;
			digit4 = currentNumber % 10;
			currentNumber /= 10;
			digit3 = currentNumber % 10;
			currentNumber /= 10;
			digit2 = currentNumber % 10;
			digit1 = currentNumber /= 10;

			Console.WriteLine(digit1);
			Console.WriteLine(digit2);
			Console.WriteLine(digit3);
			Console.WriteLine(digit4);
			Console.WriteLine(digit5);
		}
	}
}
