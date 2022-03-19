using Coding.Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Coding.Exercise;

public class UnitTestDecorator
{
    [Fact]
    public void Test_Age_not_set()
    {
        var dragon = new Dragon();
        Assert.Equal("too young", dragon.Crawl());
        Assert.Equal("flying", dragon.Fly());
    }

    [Fact]
    public void Test_Age_0()
    {
        var dragon = new Dragon() {
            Age = 0,
        };
        Assert.Equal("too young", dragon.Crawl());
        Assert.Equal("flying", dragon.Fly());
    }

    [Fact]
    public void Test_Age_2()
    {
        var dragon = new Dragon() {
            Age = 2,
        };
        Assert.Equal("crawling", dragon.Crawl());
        Assert.Equal("flying", dragon.Fly());
    }

    [Fact]
    public void Test_Age_11()
    {
        var dragon = new Dragon() {
            Age = 11,
        };
        Assert.Equal("crawling", dragon.Crawl());
        Assert.Equal("too old", dragon.Fly());
    }
}