using Coding.Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Coding.Exercise;

class MySingletonClass1
{
    public int Value1 { get; set; }
    private MySingletonClass1() { }

    private static Lazy<MySingletonClass1> instance = new Lazy<MySingletonClass1>(() => new MySingletonClass1());
    public static MySingletonClass1 Instance => instance.Value;
}

public class UnitTestSingleton
{
    [Fact]
    public void Test1()
    {
        Assert.True(SingletonTester.IsSingleton(() => MySingletonClass1.Instance));
        Assert.False(SingletonTester.IsSingleton(() => new object()));
    }
}