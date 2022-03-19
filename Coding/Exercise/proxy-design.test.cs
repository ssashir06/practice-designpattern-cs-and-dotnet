using Coding.Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Coding.Exercise;

public class UnitTestProxy
{
    [Fact]
    public void Test_Age15()
    {
        var person = new Person()
        {
            Age = 15,
        };
        var proxy = new ResponsiblePerson(person);
        Assert.Equal("too young", proxy.Drive());
        Assert.Equal("too young", proxy.Drink());
        Assert.Equal("dead", proxy.DrinkAndDrive());
    }

    [Fact]
    public void Test_Age16()
    {
        var person = new Person()
        {
            Age = 16,
        };
        var proxy = new ResponsiblePerson(person);
        Assert.Equal("driving", proxy.Drive());
        Assert.Equal("too young", proxy.Drink());
        Assert.Equal("dead", proxy.DrinkAndDrive());
    }


    [Fact]
    public void Test_Age18()
    {
        var person = new Person()
        {
            Age = 18,
        };
        var proxy = new ResponsiblePerson(person);
        Assert.Equal("driving", proxy.Drive());
        Assert.Equal("drinking", proxy.Drink());
        Assert.Equal("dead", proxy.DrinkAndDrive());
    }
}