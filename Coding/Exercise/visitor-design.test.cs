using Coding.Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Coding.Exercise;

public class UnitTestVisitor
{
    [Fact]
    public void Test1()
    {
        var simple = new AdditionExpression(new Value(2), new Value(3));
        var ep = new ExpressionPrinter();
        ep.Visit(simple);
        Assert.Equal("(2+3)", ep.ToString());
    }

    [Fact]
    public void Test2()
    {
        var simple = new MultiplicationExpression(new Value(2), new Value(3));
        var ep = new ExpressionPrinter();
        ep.Visit(simple);
        Assert.Equal("(2*3)", ep.ToString());
    }

    [Fact]
    public void Test3()
    {
        var simple = new MultiplicationExpression(new Value(2), 
            new AdditionExpression(new Value(3), new Value(4)));
        var ep = new ExpressionPrinter();
        ep.Visit(simple);
        Assert.Equal("(2*(3+4))", ep.ToString());
    }
}