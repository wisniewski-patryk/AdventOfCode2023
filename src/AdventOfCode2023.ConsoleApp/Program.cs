using AdventOfCode2023.Day_1;
using AdventOfCode2023.Day_2;
using AdventOfCode2023.Day_3;
using AdventOfCode2023.Day_4;

Console.WriteLine("Hello, Advent of Code 2023!!");
var currentDay = 4;

switch (currentDay)
{
	case 1:
		var puzzle1 = new Day1();
		var solutionPuzzle1 = puzzle1.Solution();
		Console.WriteLine("Solution Puzzle 1.1: " + solutionPuzzle1);
		break;
	case 2:
		var puzzle2 = new Day2();
		var solutionPuzzle2 = puzzle2.Solution();
		Console.WriteLine("Solution Puzzle 2.1: " + solutionPuzzle2.sum);
		Console.WriteLine("Solution Puzzle 2.2: " + solutionPuzzle2.powerSum);
		break;
	case 3:
		var puzzle3 = new Day3();
		var solutionPuzzle3 = puzzle3.Solution();
		Console.WriteLine("Solution Puzzle 3.1: " + solutionPuzzle3);
		break;
	case 4:
		var puzzle4 = new Day4();
		var solutionPuzzle4 = puzzle4.Solution();
		Console.WriteLine("Solution Puzzle 4.1: " + solutionPuzzle4);
		break;
	default:
		break;
}
