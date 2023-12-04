using System.Text.RegularExpressions;

namespace AdventOfCode2023.Day_1;

public class Day1
{
	private readonly Dictionary<string, string> spelledDigits;

    public Day1()
	{
		spelledDigits = new Dictionary<string, string>
		{
			{ "zero", "0" },
			{ "one", "1" },
			{ "two", "2" },
			{ "three", "3" },
			{ "four", "4" },
			{ "five", "5" },
			{ "six", "6" },
			{ "seven", "7" },
			{ "eight", "8" },
			{ "nine", "9" }
		};
    }

    public int Solution()
	{
		var input = File.ReadAllLines(@".\Inputs\inputPuzzle1.txt");
		return SolvePuzzle(input);
	}

	public int GetInteger(string input)
	{
		var firstDigit = input.First(System.Char.IsDigit);
		var lastDigit = input.Last(System.Char.IsDigit);

		var append = $"{firstDigit}{lastDigit}";
		var asInt = int.Parse(append);
		return asInt;
	}

	public int SolvePuzzle(string[] lines)
	{
		int sum = 0;
		foreach (var line in lines)
		{
			var integer = GetInteger(line);
			sum += integer;
		}
		return sum;
	}

	public string TransformSpelledDigitsToInteger(string input)
	{
		throw new NotImplementedException();
	}
}
