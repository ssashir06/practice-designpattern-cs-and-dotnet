using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Coding.Exercise;

public class UnitTestFacade
{
    private void PrintResult(List<List<int>> square)
    {
        var rowCount = square.Count;
        var colCount = square[0].Count;
        var sb = new StringBuilder();

        for (var c = 0; c < colCount; c++)
        {
            for (var r = 0; r < rowCount; r++)
            {
                sb.Append($"Row: {r} :\t{square[r][c]}\t");
            }
            sb.AppendLine();
        }

        Console.WriteLine(sb);
    }

    [Fact]
    public void Test_3x3()
    {
        var square = new MagicSquareGenerator().Generate(3);
        PrintResult(square);
    }

    [Fact]
    public void Test_4x4()
    {
        var square = new MagicSquareGenerator().Generate(4);
        PrintResult(square);
    }

}