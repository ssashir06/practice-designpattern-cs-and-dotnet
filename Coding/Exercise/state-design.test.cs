using Coding.Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Coding.Exercise;

public class UnitTestState
{
    [Fact]
    public void Test_Success()
    {
        var cl = new CombinationLock(new[] { 1, 2, 3, 4, 5 });
        Assert.Equal("LOCKED", cl.Status);
        cl.EnterDigit(1);
        Assert.Equal("1", cl.Status);
        cl.EnterDigit(2);
        Assert.Equal("12", cl.Status);
        cl.EnterDigit(3);
        Assert.Equal("123", cl.Status);
        cl.EnterDigit(4);
        Assert.Equal("1234", cl.Status);
        cl.EnterDigit(5);
        Assert.Equal("OPEN", cl.Status);
    }

    [Fact]
    public void Test_Failed_1()
    {
        var cl = new CombinationLock(new[] { 1, 2, 3, 4, 5 });
        Assert.Equal("LOCKED", cl.Status);
        cl.EnterDigit(1);
        Assert.Equal("1", cl.Status);
        cl.EnterDigit(2);
        Assert.Equal("12", cl.Status);
        cl.EnterDigit(3);
        Assert.Equal("123", cl.Status);
        cl.EnterDigit(4);
        Assert.Equal("1234", cl.Status);
        cl.EnterDigit(9);
        Assert.Equal("ERROR", cl.Status);
    }

    [Fact]
    public void Test_Failed_2()
    {
        var cl = new CombinationLock(new[] { 1, 2, 3, 4, 5 });
        Assert.Equal("LOCKED", cl.Status);
        cl.EnterDigit(1);
        Assert.Equal("1", cl.Status);
        cl.EnterDigit(2);
        Assert.Equal("12", cl.Status);
        cl.EnterDigit(3);
        Assert.Equal("123", cl.Status);
        cl.EnterDigit(9);
        Assert.Equal("1239", cl.Status);
        cl.EnterDigit(9);
        Assert.Equal("ERROR", cl.Status);
    }
}