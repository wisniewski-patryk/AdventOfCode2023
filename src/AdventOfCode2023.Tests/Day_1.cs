using AdventOfCode2023.Day_1;

namespace AdventOfCode2023.Tests;

public class Day_1
{
    private readonly Puzzle1 subject;

    public Day_1()
    {
        this.subject = new Puzzle1();
    }

    [Theory]
    [InlineData("1abc2", 12)]
    [InlineData("pqr3stu8vwx", 38)]
    [InlineData("a1b2c3d4e5f", 15)]
    [InlineData("treb7uchet", 77)]
    public void GetInteger(string code, int result)
    {
        var solvedLine = this.subject.GetInteger(code);
        solvedLine.Should().Be(result);
    }

    [Fact]
    public void SolvePuzzle()
    {
        string[] lines = [ "1abc2", "pqr3stu8vwx", "a1b2c3d4e5f", "treb7uchet"];
        var result = subject.SolvePuzzle(lines);

        result.Should().Be(142);
    }

    [Theory]
    [InlineData("two1nine", "219")]
    [InlineData("eightwothree", "823")]
    [InlineData("abcone2threexyz", "ab123xyz")]
    [InlineData("xtwone3four", "x2ne34")]
    [InlineData("4nineeightseven2", "49872")]
    [InlineData("zoneight234", "z1ight234")]
    [InlineData("7pqrstsixteen", "7pqrst6teen")]
    public void TransformSpeledToIngered(string input, string result)
    {
        string notSpelled = this.subject.TransformSpelledDigitsToInteger(input);
        notSpelled.Should().Be(result);
    }
}