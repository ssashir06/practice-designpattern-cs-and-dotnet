using Coding.Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Coding.Exercise;

public class UnitTestTemplate
{
    [Fact]
    public void Test_Temporary_1()
    {
        var game = new TemporaryCardDamageGame(
            new[] { new Creature(1, 2), new Creature(1, 3)}
            );
        Assert.Equal(-1, game.Combat(0, 1));
        Assert.Equal(-1, game.Combat(0, 1));
        Assert.Equal(-1, game.Combat(0, 1));
    }

    [Fact]
    public void Test_Permanent_1()
    {
        var game = new PermanentCardDamage(
            new[] { new Creature(1, 2), new Creature(1, 3) }
            );
        Assert.Equal(-1, game.Combat(0, 1));
        Assert.Equal(1, game.Combat(0, 1));
    }
}