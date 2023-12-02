namespace AdventOfCode2023.Day_2;

public class Puzzle2
{
	public record Part1(bool IsPossible, int GameNumber);
	public record Part2(int MaxRedCubes, int MaxGreenCubes, int MaxBlueCubes, int Power);
	public (int sum, int powerSum) Solution()
	{
		var input = File.ReadAllLines(@".\Inputs\inputPuzzle2.txt");
		return SolvePuzzle2(input);
	}

	public (int sum, int power)SolvePuzzle2(string[] input)
	{
		var sum = 0;
		var powerSum = 0;
		foreach (var line in input)
		{
			(var part1, var part2) = IterateTroughInput(line);
			if (part1.IsPossible)
			{
				sum += part1.GameNumber;
			}
			powerSum += part2.Power;
		}
		return (sum, powerSum);
	}

	public (Part1 part1, Part2 part2) IterateTroughInput(string inputGame)
	{
		var spiteGameNumberAndResults = inputGame.Split(':');
		var gameNumber = int.Parse(spiteGameNumberAndResults[0].Trim().Split(' ')[1]);
		var resultsArray = spiteGameNumberAndResults[1].Trim().Split(';');

		var maxRedCubes = 0;
		var maxGreenCubes = 0;
		var maxBlueCubes = 0;

		var isPossible = true;
		foreach (var result in resultsArray)
		{
			
			var cubesInColors = result.Split(',');
			foreach (var color in cubesInColors)
			{
				var split = color.Trim().Split(" ");
				var cubesCount = int.Parse(split[0].Trim());
				var cubesColor = split[1].Trim();
				switch (cubesColor)
				{
					case "red":
						if (cubesCount > 12) isPossible = false;
						if (cubesCount > maxRedCubes) maxRedCubes = cubesCount;
						break;
					case "green":
						if (cubesCount > 13) isPossible = false;
						if (cubesCount > maxGreenCubes) maxGreenCubes = cubesCount;
						break;
					case "blue":
						if (cubesCount > 14) isPossible = false;
						if (cubesCount > maxBlueCubes) maxBlueCubes = cubesCount;
						break;
				}
			}
		}
		var power = maxRedCubes * maxGreenCubes * maxBlueCubes;
		return (new Part1(isPossible, gameNumber), new Part2(maxRedCubes, maxGreenCubes, maxBlueCubes, power));
	}
}