using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_The_Trainers__HOME_
{
	class Program
	{
		static void Main(string[] args)
		{
			string presentation = string.Empty;

			int numberOfGrades = int.Parse(Console.ReadLine());

			double totalSumGrades = 0;
			int counterPresentations = 0;

			while (presentation != "Finish")
			{
				
				presentation = Console.ReadLine();

				if (presentation == "Finish")
				{
					break;
				}

				double sumGrades = 0;


				for (int i = 1; i <= numberOfGrades; i++)
				{
					double grade = double.Parse(Console.ReadLine());
					sumGrades += grade;
				}

				totalSumGrades += sumGrades;
				counterPresentations++;

				Console.WriteLine($"{presentation} - { (sumGrades / numberOfGrades):F2}.");

			}

			Console.WriteLine($"Student's final assessment is {(totalSumGrades / (counterPresentations * numberOfGrades)):F2}.");
			
		}
	}
}
