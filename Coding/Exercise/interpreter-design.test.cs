using Coding.Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Coding.Exercise;

public class UnitTestInterpreter
{
    [Fact]
    public void Test1()
    {
        var interpreter = new ExpressionProcessor();
        Assert.Equal(6, interpreter.Calculate("1+2+3"));
    }

    [Fact]
    public void Test2()
    {
        var interpreter = new ExpressionProcessor();
        Assert.Equal(0, interpreter.Calculate("1+2+xy"));
    }

    [Fact]
    public void Test3()
    {
        var interpreter = new ExpressionProcessor();
        interpreter.Variables['x'] = 3;
        Assert.Equal(5, interpreter.Calculate("10-2-x"));
    }
}