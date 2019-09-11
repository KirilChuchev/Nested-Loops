using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			int c = int.Parse(Console.ReadLine());
			int d = int.Parse(Console.ReadLine());

			for (int thousands = a; thousands <= b; thousands++)
			{
				for (int hundereds = a; hundereds <= b; hundereds++)
				{
					for (int tens = c; tens <= d; tens++)
					{
						for (int ones = c; ones <= d; ones++)
						{
							if (thousands != hundereds && tens != ones && (thousands + ones) == (hundereds + tens))
							{
								
								Console.WriteLine("" + thousands + hundereds);
								Console.WriteLine("" + tens + ones);
								Console.WriteLine();
							}
						}
					}
				}
			}



			
		}
	}
}
