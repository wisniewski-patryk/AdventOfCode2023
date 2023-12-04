namespace AdventOfCode2023.Day_3;

public class Day3
{ 
	public int Solution()
	{
		var input = File.ReadAllLines(@".\Inputs\inputPuzzle3.txt");
		return SolvePuzzle3(input);
	}

	public int SolvePuzzle3(string[] input)
	{
		char[][] charsArray = input.Select(str => str.ToCharArray()).ToArray();

		var sum = 0;
		var stringDigits = new List<char>();
		var anySymbolAround = false;

		for (int y = 0; y < charsArray.Length; y++)
		{
			for (int x = 0; x < charsArray[y].Length; x++)
			{
				var preview = charsArray[y][x];
				if (char.IsDigit(charsArray[y][x]))
				{
					bool?[] around = [
						TryGetUpLeftCell(),
						TryGetUpCell(),
						TryGetUpRightCell(),
						TryGetLeftCell(),
						TryGetRightCell(),
						TryGetLeftDownCell(),
						TryGetDownCell(),
						TryGetRightDownCell(),
					];

					stringDigits.Add(charsArray[y][x]);

					if (around.Any(a => a.HasValue && a.Value))
					{
						anySymbolAround = true;
					}

				}
				else
				{
					if (stringDigits.Count > 0 && anySymbolAround)
					{
						var digit = int.Parse(stringDigits.ToArray());
						sum += digit;
						stringDigits.Clear();
						anySymbolAround = false;
					}
					if (stringDigits.Count > 0 && !anySymbolAround) stringDigits.Clear();
				}

				#region TryGetCells
				bool? TryGetUpLeftCell()
				{
					try
					{
						return charsArray[y - 1][x - 1] != '.' && !char.IsNumber(charsArray[y - 1][x - 1]);
					} catch (Exception) { return null; }
				}
				bool? TryGetUpCell()
				{
					try
					{
						return !char.IsNumber(charsArray[y - 1][x]) && charsArray[y - 1][x] != '.';
					} catch (Exception) { return null; }
				}
				bool? TryGetUpRightCell()
				{
					try
					{
						return !char.IsNumber(charsArray[y - 1][x + 1]) && charsArray[y - 1][x + 1] != '.';
					} catch (Exception) { return null; }
				}
				bool? TryGetLeftCell()
				{
					try
					{
						return !char.IsNumber(charsArray[y][x - 1]) && charsArray[y][x - 1] != '.';
					} catch (Exception) { return null; }
				}
				bool? TryGetRightCell()
				{
					try
					{
						return !char.IsNumber(charsArray[y][x + 1]) && charsArray[y][x + 1] != '.';
					} catch (Exception) { return null; }
				}
				bool? TryGetLeftDownCell()
				{
					try
					{
						return !char.IsNumber(charsArray[y + 1][x - 1]) && charsArray[y + 1][x - 1] != '.';
					} catch (Exception) { return null; }
				}
				bool? TryGetDownCell()
				{
					try
					{
						return !char.IsNumber(charsArray[y + 1][x]) && charsArray[y + 1][x] != '.';
					} catch (Exception) { return null; }
				}
				bool? TryGetRightDownCell()
				{
					try
					{
						return !char.IsNumber(charsArray[y + 1][x + 1]) && charsArray[y + 1][x + 1] != '.';
					} catch (Exception) { return null; }
				}
				#endregion 
			}
		}

		return sum;
	}

}
