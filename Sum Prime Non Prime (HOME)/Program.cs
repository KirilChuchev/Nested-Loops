using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Prime_Non_Prime__HOME_
{
	class Program
	{
		static void Main(string[] args)
		{
			string command = string.Empty;

			int sumPrime = 0;
			int sumNonPrime = 0;

			bool stop = false;



			while (command != "stop")
			{
				command = Console.ReadLine();
				if (command == "stop")
				{
					break;
				}

				int number = int.Parse(command);

				while (number < 0)
				{
					Console.WriteLine("Number is negative.");
					command = Console.ReadLine();

					if (command == "stop")
					{
						stop = true;
						break;
						
					}

					number = int.Parse(command);

				}

				if (stop)
				{
					break;
				}

				int counterPrime = 0;
				

				
				
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
				

			}

			Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
			Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");



		}
	}
}
