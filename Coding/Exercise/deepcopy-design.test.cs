using Coding.Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Coding.Exercise;

public class UnitTestDeepcopy
{
    [Fact]
    public void Test1()
    {
        var orig = new Line() {
            Start = new Point() {
                X = 10, Y = 20,
            },
            End = new Point() {
                X = 30, Y = 40,
            },
        };
        var duplicated = orig.DeepCopy();

        Assert.Equal(orig.Start.X, duplicated.Start.X);
        Assert.Equal(orig.Start.Y, duplicated.Start.Y);
        Assert.Equal(orig.End.X, duplicated.End.X);
        Assert.Equal(orig.End.Y, duplicated.End.Y);
        Assert.NotEqual(orig.Start, duplicated.Start);
        Assert.NotEqual(orig.End, duplicated.End);
    }
}