using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_the_trainers
{
	class Program
	{
		static void Main(string[] args)
		{
			int countJury = int.Parse(Console.ReadLine());

			double sumGradesAll = 0;
			int countAllGrades = 0;

			string presentation = Console.ReadLine();

			while (presentation != "Finish")
			{
				double sum = 0;

				for (int i = 0; i < countJury; i++)
				{
					double grade = double.Parse(Console.ReadLine());
					sum += grade;

					sumGradesAll += grade;
					countAllGrades++;
				}
				double average = sum / countJury;
				

				Console.WriteLine($"{presentation} - {average:F2}.");
				
				presentation = Console.ReadLine();
			}

			double averageTotal = sumGradesAll / countAllGrades;
			Console.WriteLine($"Student's final assessment is {averageTotal:F2}.");
		}
	}
}
