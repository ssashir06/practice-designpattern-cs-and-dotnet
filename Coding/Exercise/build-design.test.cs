using System;
using Xunit;

namespace Coding.Exercise;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");
        Console.WriteLine(cb);
    }
    
}