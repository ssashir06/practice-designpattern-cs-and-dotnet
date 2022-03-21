using Coding.Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Coding.Exercise;

public class UnitTestNullObject
{
    [Fact]
    public void Test1()
    {
        var a = new Account(new NullLog());
        for (var i = 0; i < 10; i++) {
            a.SomeOperation();
        }
    }
}