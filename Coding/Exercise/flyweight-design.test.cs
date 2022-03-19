using Coding.Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Coding.Exercise;

public class UnitTestFlyweight
{
    [Fact]
    public void Test1()
    {
        var sentence = new Sentence("hello world");
        sentence[1].Capitalize = true;
        Assert.Equal("hello WORLD", sentence.ToString());
    }
}