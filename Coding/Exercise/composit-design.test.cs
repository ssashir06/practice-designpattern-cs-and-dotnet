using System;
using Xunit;

namespace Coding.Exercise;

public class UnitTestComposit
{
    [Fact]
    public void TestSingleValues()
    {
        var single1 = new SingleValue() { Value = 1 };
        var single2 = new SingleValue() { Value = 2 };
        var single3 = new SingleValue() { Value = 3 };
        Assert.Equal(1, new IValueContainer[] { single1 }.Sum());
        Assert.Equal(2, new IValueContainer[] { single2 }.Sum());
        Assert.Equal(3, new IValueContainer[] { single3 }.Sum());
        Assert.Equal(6, new IValueContainer[] { single1, single2, single3 }.Sum());
    }

    [Fact]
    public void TestManyValues()
    {
        var many6 = new ManyValues() { 1, 2, 3 };
        var many15 = new ManyValues() { 4, 5, 6 };
        var many26 = new ManyValues() { 7, 9 ,10 };
        Assert.Equal(6, new IValueContainer[] { many6 }.Sum());
        Assert.Equal(15, new IValueContainer[] { many15 }.Sum());
        Assert.Equal(26, new IValueContainer[] { many26 }.Sum());
        Assert.Equal(47, new IValueContainer[] { many6, many15, many26 }.Sum());
    }

    [Fact]
    public void TestManyValuesAndSingleValues()
    {
        IValueContainer many6 = new ManyValues() { 1, 2, 3 };
        IValueContainer single3 = new SingleValue() { Value = 3 };
        Assert.Equal(9, new IValueContainer[] { many6, single3 }.Sum());
    }
    
}