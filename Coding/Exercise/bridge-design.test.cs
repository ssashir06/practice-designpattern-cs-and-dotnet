using System;
using Xunit;

namespace Coding.Exercise;

public class UnitTestBridge
{
    [Fact]
    public void Test1()
    {
        Assert.Equal("Drawing Triangle as pixels", new Triangle(new RasterRenderer()).ToString());
        Assert.Equal("Drawing Square as pixels", new Square(new RasterRenderer()).ToString());
        Assert.Equal("Drawing Triangle as lines", new Triangle(new VectorRenderer()).ToString());
        Assert.Equal("Drawing Square as lines", new Square(new VectorRenderer()).ToString());
    }

}