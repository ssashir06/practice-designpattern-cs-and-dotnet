using Coding.Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Coding.Exercise;

public class UnitTestObserver
{
    [Fact]
    public void Test1()
    {
        var game = new Game();
        using (var rat1 = new Rat(game))
        {

            Assert.Equal(1, rat1.Attack);
            using (var rat2 = new Rat(game))
            {
                Assert.Equal(2, rat1.Attack);
                Assert.Equal(2, rat2.Attack);
            }
            Assert.Equal(1, rat1.Attack);
        }
    }
}