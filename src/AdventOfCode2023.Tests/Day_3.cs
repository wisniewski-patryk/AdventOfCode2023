using AdventOfCode2023.Day_3;

namespace AdventOfCode2023.Tests;

public class Day_3
{
	private readonly Day3 subject;
	public Day_3()
	{
		this.subject = new Day3();
	}

	[Fact]
	public void CheckGameIsPossible()
	{
		string[] input = [
			"467..114..",
			"...*......", 
			"..35..633.", 
			"......#...", 
			"617*......", 
			".....+.58.", 
			"..592.....", 
			"......755.", 
			"...$.*....", 
			".664.598.."];

		var result = this.subject.SolvePuzzle3(input);

		result.Should().Be(4361);
	}

}
