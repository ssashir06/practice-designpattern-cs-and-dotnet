using Coding.Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Coding.Exercise;

public class UnitTestFactory
{
    [Fact]
    public void Test1()
    {
        var factory = new PersonFactory();
        var person1 = factory.CreatePerson("Man A");
        var person2 = factory.CreatePerson("Woman B");

        Assert.Equal(0, person1.Id);
        Assert.Equal("Man A", person1.Name);
        Assert.Equal(1, person2.Id);
        Assert.Equal("Woman B", person2.Name);
    }
}