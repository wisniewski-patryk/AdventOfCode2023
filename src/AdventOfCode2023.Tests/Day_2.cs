using AdventOfCode2023.Day_2;

namespace AdventOfCode2023.Tests;

public class Day_2
{
	private readonly Day2 subject;
	public Day_2()
	{
		this.subject = new Day2();
	}

	[Theory]
	[InlineData("Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green", true)]
	[InlineData("Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue", true)]
	[InlineData("Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red", false)]
	[InlineData("Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red", false)]
	[InlineData("Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green", true)]
	public void CheckGameIsPossible(string gameInput, bool isPossible)
	{
		var result = this.subject.IterateTroughInput(gameInput);

		result.part1.IsPossible.Should().Be(isPossible);
	}

	[Theory]
	[InlineData("Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green", 48)]
	[InlineData("Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue", 12)]
	[InlineData("Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red", 1560)]
	[InlineData("Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red", 630)]
	[InlineData("Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green", 36)]
	public void CheckPower(string gameInput, int power) 
	{
		var result = this.subject.IterateTroughInput(gameInput);

		result.part2.Power.Should().Be(power);
	}

	[Fact]
	public void SolvePuzzle1()
	{
		string[] input = [
			"Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green",
			"Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue",
			"Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red",
			"Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red",
			"Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green"
			];

		var result = this.subject.SolvePuzzle2(input);

		result.sum.Should().Be(8);
	}
}
