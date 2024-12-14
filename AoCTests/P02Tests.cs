
using AdventOfCode2024._02;

namespace AoCTests;

public class P02Tests
{

    int[][] input = new int[6][]
    {
        [7, 6, 4, 2, 1],
        [1, 2, 7, 8, 9],
        [9, 7, 6, 2, 1],
        [1, 3, 2, 4, 5],
        [8, 6, 4, 4, 1],
        [1, 3, 6, 7, 9]
    };
    
    [Fact]
    public async Task Part1()
    {
        P02 _ = new P02();
        var safe = _.PartOne(input);
        Assert.Equal(2, safe);
    }
    
    [Fact]
    public async Task Part2()
    {
        P02 _ = new P02();
        var safe = _.PartTwo(input);
        Assert.Equal(0, -1);
    }
}