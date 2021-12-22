using System;
using System.Collections.Generic;

namespace advent_of_code_2021
{
	class Lanternfish
	{
		public static void Spawning()
		{

			List<int> fish = new List<int> { 4, 1, 3, 2, 4, 3, 1, 4, 4, 1, 1, 1, 5, 2, 4, 4, 2, 1, 2, 3, 4, 1, 2, 4, 3, 4, 5, 1, 1, 3, 1, 2, 1, 4, 1, 1, 3, 4, 1, 2, 5, 1, 4, 2, 2, 1, 1, 1, 3, 1, 5, 3, 1, 2, 1, 1, 1, 1, 4, 1, 1, 1, 2, 2, 1, 3, 1, 3, 1, 3, 4, 5, 1, 2, 2, 1, 1, 1, 4, 1, 5, 1, 3, 1, 3, 4, 1, 3, 2, 3, 4, 4, 4, 3, 4, 5, 1, 3, 1, 3, 5, 1, 1, 1, 1, 1, 2, 4, 1, 2, 1, 1, 1, 5, 1, 1, 2, 1, 3, 1, 4, 2, 3, 4, 4, 3, 1, 1, 3, 5, 3, 1, 1, 5, 2, 4, 1, 1, 3, 5, 1, 4, 3, 1, 1, 4, 2, 1, 1, 1, 1, 1, 1, 3, 1, 1, 1, 1, 1, 4, 5, 1, 2, 5, 3, 1, 1, 3, 1, 1, 1, 1, 5, 1, 2, 5, 1, 1, 1, 1, 1, 1, 3, 5, 1, 3, 2, 1, 1, 1, 1, 1, 1, 1, 4, 5, 1, 1, 3, 1, 5, 1, 1, 1, 1, 3, 3, 1, 1, 1, 4, 4, 1, 1, 4, 1, 2, 1, 4, 4, 1, 1, 3, 4, 3, 5, 4, 1, 1, 4, 1, 3, 1, 1, 5, 5, 1, 2, 1, 2, 1, 2, 3, 1, 1, 3, 1, 1, 2, 1, 1, 3, 4, 3, 1, 1, 3, 3, 5, 1, 2, 1, 4, 1, 1, 2, 1, 3, 1, 1, 1, 1, 1, 1, 1, 4, 5, 5, 1, 1, 1, 4, 1, 1, 1, 2, 1, 2, 1, 3, 1, 3, 1, 1, 1, 1, 1, 1, 1, 5 };

			List<int> immortalFish = new List<int>(fish);

			Console.WriteLine("6.1 fish after 80 days");
			for (int day = 0; day < 80; day++)
			{
				NewDay(fish);
			}

			Console.WriteLine($"After 80 days there would be {fish.Count} fish.");

			Console.WriteLine("6.2 immortal fish after 256 days");

			// this was the biggest swing in difficulty from a part 1 to a part 2 so far
			// the calculation is too intensive to do like in 6.1
			// a hint online suggested grouping fish by their reproduction timers so I tried that below

			long[] breedingPool = new long[7];
			long[] juvenilePool = new long[7];

			// group up the fish by age on day 0
			foreach (var item in immortalFish)
			{
				breedingPool[item]++;
			}

			for (int day = 0; day < 256; day++) // we loop through all days
			{
				int i = day % 7; // we spawn new fish based on the day divided by 7, because every 7 days they spawn again

				juvenilePool[(i + 2) % 7] = breedingPool[i]; // the newly spawned fish are added to a new array 2 days after their birthday e.g. if spawned on day = 1 they're added to juvenile day = 3
				breedingPool[i] = breedingPool[i] + juvenilePool[i]; // After the spawning for a day is done, the juvenile pool gets put into the breeding pool
				juvenilePool[i] = 0;
			}

			foreach (var item in breedingPool)
			{
				Console.Write($"{item} ");
			}
			Console.WriteLine();
			foreach (var item in juvenilePool)
			{
				Console.Write($"{item} ");
			}
			Console.WriteLine();

			long totalImmortalFish = 0;
			for (int i = 0; i < breedingPool.GetLength(0); i++) // totalling up the fish over all days and both pools
			{
				totalImmortalFish = totalImmortalFish + breedingPool[i] + juvenilePool[i];
			}

			Console.WriteLine($"After 256 days there would be {totalImmortalFish} immortal fish.");

		}

		public static void NewDay(List<int> fish)
		{
			int numberOfFishBeforeSpawn = fish.Count; // want to make sure that the newly spawned fish don't get aged also

			for (int i = 0; i < numberOfFishBeforeSpawn; i++)
			{
				if (fish[i] == 0)
				{
					fish[i] = 6;
					fish.Add(8);
				}
				else
				{
					fish[i]--;
				}
			}
		}
	}
}