
using AdventOfCode2024._01;

namespace AoCTests;

public class P01Tests
{

    int[][] input = new int[2][]
    {
        [3, 4, 2, 1, 3, 3],
        [4, 3, 5, 3, 9, 3]
    };
    
    [Fact]
    public async Task Part1()
    {
        P01 _ = new P01();
        await _.Presort(input);


        var sum = _.PartOne(input);
        Assert.Equal(11, sum);
    }
    
    [Fact]
    public async Task Part2()
    {
        P01 _ = new P01();
        await _.Presort(input);
        
        Dictionary<int, int> memoizedNumbers = new Dictionary<int, int>();
        for (int i = 0; i < input[0].Length; i++)
        {
            if (memoizedNumbers.TryGetValue(input[1][i], out var oldVal))
            {
                memoizedNumbers[input[1][i]] = oldVal + 1;
            }
            else
            {
                memoizedNumbers[input[1][i]] = 0;
            }
        }

        var sum = _.PartTwo(input, memoizedNumbers);
        Assert.Equal(31, sum);
    }
}