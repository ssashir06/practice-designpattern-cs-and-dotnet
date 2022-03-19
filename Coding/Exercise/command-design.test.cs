using Coding.Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Coding.Exercise;

public class UnitTestCommand
{
    [Fact]
    public void Test1()
    {
        var account = new Account();
        var commands = new[]
        {
            new Command() { TheAction = Command.Action.Deposit, Amount = 100 },
            new Command() { TheAction = Command.Action.Withdraw, Amount = 50 },
            new Command() { TheAction = Command.Action.Withdraw, Amount = 50 },
            new Command() { TheAction = Command.Action.Withdraw, Amount = 50 },
        };
        foreach (var command in commands)
        {
            account.Process(command);
            if (!command.Success)
            {
                break;
            }
        }
        Assert.Equal(0, account.Balance);
    }

    [Fact]
    public void Test2()
    {
        var account = new Account();
        var commands = new[]
        {
            new Command() { TheAction = Command.Action.Deposit, Amount = 100 },
            new Command() { TheAction = Command.Action.Withdraw, Amount = 40 },
            new Command() { TheAction = Command.Action.Withdraw, Amount = 50 },
            new Command() { TheAction = Command.Action.Withdraw, Amount = 50 },
        };
        foreach (var command in commands)
        {
            account.Process(command);
            if (!command.Success)
            {
                break;
            }
        }
        Assert.Equal(10, account.Balance);
    }
}