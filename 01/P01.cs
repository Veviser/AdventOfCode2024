namespace AdventOfCode2024._01;

public class P01 : IProblem
{
    public async Task Eval()
    {
        var input = ReadInput();
    }

    int[][] ReadInput()
    {
        var input = new int[2][];
        input[0] = new int[1000]; // I know there are 1k lines, not bothering making it generic
        input[1] = new int[1000];
        using (var reader = File.OpenText("01/input.txt"))
        {
            for (int i = 0; i < input[0].Length; i++)
            {
                var line = reader.ReadLine()!.Split("  ");
                input[0][i] = int.Parse(line[0]);
                input[1][i] = int.Parse(line[1]);
            }
        }
        return input;
    }
}