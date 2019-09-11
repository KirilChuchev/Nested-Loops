using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing__HOME____1
{
	class Program
	{
		static void Main(string[] args)
		{
			int countFishes = int.Parse(Console.ReadLine());


			double fishWeight = 0;

			int currentFish = 0;

			double fishPrice = 0;
			double sumFishPrices = 0;


			while (true)
			{
				currentFish++;

				if (currentFish > countFishes)
				{
					break;
				}

				string fishName = Console.ReadLine();

				if (fishName == "Stop")
				{
					break;
				}

				fishWeight = double.Parse(Console.ReadLine());
				

				for (int i = 0; i < fishName.Length; i++)
				{
					int symbol = (int)fishName[i];
					fishPrice += symbol;
				}
				fishPrice /= fishWeight;


				if (currentFish % 3 == 0)
				{
					sumFishPrices += fishPrice;
				}
				else
				{
					sumFishPrices -= fishPrice;
				}

				fishPrice = 0;

			}

			if (currentFish > countFishes)
			{
				Console.WriteLine("Lyubo fulfilled the quota!");
			}

			if (sumFishPrices >= 0)
			{
				Console.WriteLine($"Lyubo's profit from {currentFish - 1} fishes is {sumFishPrices:F2} leva.");
			}
			else
			{
				Console.WriteLine($"Lyubo lost {Math.Abs(sumFishPrices):F2} leva today.");
			}

		}
	}
}
