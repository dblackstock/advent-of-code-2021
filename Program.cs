using System;

namespace advent_of_code_2021
{
	class Program
	{
		static void Main(string[] args)
		{
			// manually update which function is being called
			// in order to solve various challenges
			Console.WriteLine("Which day do you want to see output for?");
			string day = Console.ReadLine();

			switch (day)
			{
				case "1":
					DepthCheck.SonarSweep();
					break;
				case "2":
					Dive.Navigation();
					break;
				case "3":
					BinaryDiagnostic.Diagnostic();
					break;
				default:
					Console.WriteLine("Day not found. Please enter a value from 1 to 25. Perhaps your chosen value has not been added yet.");
					break;
			}
		}
	}
}
