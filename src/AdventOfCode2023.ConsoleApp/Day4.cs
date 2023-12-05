namespace AdventOfCode2023.Day_4;

public class Day4
{
	public int Solution()
	{
		var input = File.ReadAllLines(@".\Inputs\inputPuzzle4.txt");
		var sum = 0;
		foreach (var line in input)
		{
			sum += GetScore(line);
		}
		return sum;
	}

	public int GetScore(string input)
	{
		var splitGameNumberFromNumbers = input.Split(':');
		var splitWinnerNumbersFromPlayerNumbers = splitGameNumberFromNumbers[1].Trim().Split("|");
		var winnerNumbers = splitWinnerNumbersFromPlayerNumbers[0].Trim().Split(' ').Select(s =>
		{
			_ = int.TryParse(s.Trim(), out var result);
			return result;
		}).Where(s => s != 0);
		var playersNumbers = splitWinnerNumbersFromPlayerNumbers[1].Trim().Split(' ').Select(s =>
		{
			_ = int.TryParse(s.Trim(), out var result);
			return result;
		}).Where(s => s != 0);
		var gamePreview = splitGameNumberFromNumbers[0];
		var score = 0;
		var machedNumber = new List<int>();

		foreach (var winnerNumber in winnerNumbers)
		{
			foreach (var playersNumber in playersNumbers)
			{
				if (playersNumber == winnerNumber)
				{
					if (score == 0)
					{
						score = 1;
						machedNumber.Add(playersNumber);
					} else
					{
						score *= 2;
						machedNumber.Add(playersNumber);
					}
				}
			}
		}

		return score;
	}
}
