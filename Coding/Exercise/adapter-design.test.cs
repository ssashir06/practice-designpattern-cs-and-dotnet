using System;
using Xunit;

namespace Coding.Exercise;

public class UnitTestAdapter
{
    [Fact]
    public void Test1()
    {
        var square = new Square()
        {
            Side = 5,
        };
        var rectangle = new SquareToRectangleAdapter(square);

        Assert.Equal(5, rectangle.Width);
        Assert.Equal(5, rectangle.Height);
    }

}