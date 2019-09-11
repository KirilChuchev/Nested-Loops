using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Pyramid__HOME_
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());


			int row = 0;

			

			for (int number = 0; number < n; )
			{
				row++;
				for (int i = 1; i <= row; i++)
				{
					number += 1;
					if (number > n)
					{
						break;
					}
					Console.Write($"{number} ");
					
				}
				Console.WriteLine();
			
				
				
			}
		}
	}
}
