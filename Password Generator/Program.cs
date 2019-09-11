using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Generator
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int l = int.Parse(Console.ReadLine());

			string symbol1 = "";
			string symbol2 = "";
			string symbol3 = "";
			string symbol4 = "";
			string symbol5 = "";

			for (int i = 1; i <= n; i++)					//programata ne raboti!!!
			{
				symbol1 = i + "";
				for (int j = 1; j <= n; j++)
				{
					symbol2 = j + "";
					for (int k = 'a'; k <= 'l'; k++)
					{
						symbol3 = (char)k + "";
						for (int f = 'a'; f <= 'l'; f++)
						{
							symbol4 = (char)f + "";
							for (int w = 1; w <= n; w++)
							{
								if (w > i && w > j)
								{
									symbol5 = w + "";
									Console.Write($"{symbol1}{symbol2}{symbol3}{symbol4}{symbol5} ");
								}
							}
						}
					}
				}
			}
		}
	}
}
