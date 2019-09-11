using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Generator__HOME_
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int l = int.Parse(Console.ReadLine());

			for (int digit1 = 1; digit1 <= n; digit1++)
			{
				for (int digit2 = 1; digit2 <= n; digit2++)
				{
					for (char digit3 = 'a'; digit3 < (char)('a' + l); digit3++)
					{
						for (char digit4 = 'a'; digit4 < (char)('a' + l); digit4++)
						{
							for (int digit5 = 1; digit5 <= n; digit5++)
							{
								if (digit5 > digit1 && digit5 > digit2)
								{
									Console.Write($"{digit1}{digit2}{digit3}{digit4}{digit5} ");
								}
							}
						}
					}
				}
			}
		}
	}
}
