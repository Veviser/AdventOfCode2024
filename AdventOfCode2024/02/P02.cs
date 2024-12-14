namespace AdventOfCode2024._02;

public class P02 : IProblem
{
    public Task Eval()
    {
        var input = ReadInput();
        PartOne(input);
        PartTwo(input);
        return Task.CompletedTask;
    }

    public int PartOne(int[][] input)
    {
        throw new NotImplementedException();
    }

    public int PartTwo(int[][] input)
    {
        throw new NotImplementedException();
    }
    
    int[][] ReadInput()
    {
        var input = new int[1000][];
        using (var reader = File.OpenText("02/input.txt"))
        {
            for (int i = 0; i < input[0].Length; i++)
            {
                input[i] = reader.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            }
        }
        return input;
    }
}