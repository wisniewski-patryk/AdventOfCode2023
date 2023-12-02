using AdventOfCode2023.Day_1;
using AdventOfCode2023.Day_2;

Console.WriteLine("Hello, Advent of Code 2023!!");

var puzzle1 = new Puzzle1();
var solutionPuzzle1 = puzzle1.Solution();
Console.WriteLine("Solution Puzzle 1.1: " + solutionPuzzle1);

var puzzle2 = new Puzzle2();
var solutionPuzzle2 = puzzle2.Solution();
Console.WriteLine("Solution Puzzle 2.1: " + solutionPuzzle2.sum);
Console.WriteLine("Solution Puzzle 2.2: " + solutionPuzzle2.powerSum);

