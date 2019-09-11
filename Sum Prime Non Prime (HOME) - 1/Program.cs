using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Prime_Non_Prime__HOME____1
{
	class Program
	{
		static void Main(string[] args)
		{
			int sumPrime = 0;
			int sumNonPrime = 0;

			int counterPrime = 0;

			while (true)
			{
				string command = Console.ReadLine();

				if (command == "stop")
				{
					break;
				}

				int number = int.Parse(command);

				if (number > 0)
				{
					for (int i = 1; i <= number; i++)
					{
						if (number % i == 0)
						{
							counterPrime++;
						}

					}

					if (counterPrime == 2)
					{
						sumPrime += number;
					}
					else
					{
						sumNonPrime += number;
					}

					counterPrime = 0;

				}
				else if (number < 0)
				{
					Console.WriteLine("Number is negative.");
				}

			}

			Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
			Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
		}
	}
}
