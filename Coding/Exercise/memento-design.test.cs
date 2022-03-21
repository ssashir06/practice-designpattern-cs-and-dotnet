using Coding.Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Coding.Exercise;

public class UnitTestMemento
{
    [Fact]
    public void Test1()
    {
        var tokenMachine = new TokenMachine();
        var t1 = new Token(111);
        var m1 = tokenMachine.AddToken(t1);
        Assert.Equal(1, tokenMachine.Tokens.Count);
        Assert.Equal(111, tokenMachine.Tokens[0].Value);
        tokenMachine.Revert(m1);
        Assert.Equal(1, tokenMachine.Tokens.Count);
    }
    
    [Fact]
    public void Test2()
    {
        var tokenMachine = new TokenMachine();
        var t1 = new Token(111);
        var t2 = new Token(222);
        var m1 = tokenMachine.AddToken(t1);
        var m2 = tokenMachine.AddToken(t2);
        Assert.Equal(2, tokenMachine.Tokens.Count);
        tokenMachine.Revert(m1);
        Assert.Equal(1, tokenMachine.Tokens.Count);
    }
    
    [Fact]
    public void Test3()
    {
        var tokenMachine = new TokenMachine();
        var t1 = new Token(111);
        var t2 = new Token(222);
        var m1 = tokenMachine.AddToken(t1);
        var m2 = tokenMachine.AddToken(t2);
        Assert.Equal(2, tokenMachine.Tokens.Count);
        t1.Value = 333;
        tokenMachine.Revert(m1);
        Assert.Equal(1, tokenMachine.Tokens.Count);
        tokenMachine.Tokens[0].Value = 111;
    }
}