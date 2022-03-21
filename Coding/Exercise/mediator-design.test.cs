using Coding.Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Coding.Exercise;

public class UnitTestMediator
{
    [Fact]
    public void Test1()
    {
        var mediator = new Mediator();
        var p1 = new Participant(mediator);
        var p2 = new Participant(mediator);
        Assert.Equal(0, p1.Value);
        Assert.Equal(0, p2.Value);
        
        p1.Say(3);
        Assert.Equal(0, p1.Value);
        Assert.Equal(3, p2.Value);

        p2.Say(2);
        Assert.Equal(2, p1.Value);
        Assert.Equal(3, p2.Value);
    }
}