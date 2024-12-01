namespace AdventOfCode2024._01;

public class P01 : IProblem
{
    public async Task Eval()
    {
        var input = ReadInput(out var memoizedNumbers);
        await Presort(input);
        PartOne(input);
        PartTwo(input, memoizedNumbers);
    }

    public async Task Presort(int[][] input)
    {
        List<Task> tasks = new List<Task>(){
            Task.Run(() => Array.Sort(input[0])),
            Task.Run(() => Array.Sort(input[1]))
        };
        await Task.WhenAll(tasks);
    }

    public int PartOne(int[][] input)
    {
        var sum = 0;
        for (int i = 0; i < input[i].Length; i++)
        {
            sum += Math.Abs(input[0][i] - input[1][i]);
        }
        Console.WriteLine("Sum is " + sum);
        return sum;
    }

    public int PartTwo(int[][] input, Dictionary<int, int> memoizedNumbers)
    {
        var similarityScore = 0;
        
        foreach(var num in input[0])
        {
            memoizedNumbers.TryGetValue(num, out var score);
            similarityScore += num * score;
        }
        Console.WriteLine("Similarity score is " + similarityScore);
        return similarityScore;
    }
    int[][] ReadInput(out Dictionary<int, int> numbers)
    {
        // The number of times each number in the right list appears in the right list.
        numbers = new Dictionary<int, int>();
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
                
                if (numbers.TryGetValue(input[1][i], out var oldVal))
                {
                    numbers[input[1][i]] = oldVal + 1;
                }
                else
                {
                    numbers[input[1][i]] = 0;
                }
            }
        }
        return input;
    }
}