//using System;
//using Xunit;

//namespace Coding.Exercise;

//public class UnitTestChainOfResponsibility
//{
//    [Fact]
//    public void Test1()
//    {
//        var game = new Game();
//        var goblin = new Goblin(game);
//        game.Creatures.Add(goblin);
//        Assert.Equal(1, goblin.Attack);
//        Assert.Equal(1, goblin.Defense);
//    }

//    [Fact]
//    public void Test2()
//    {
//        var game = new Game();
//        var goblin1 = new Goblin(game);
//        var goblin2 = new Goblin(game);
//        game.Creatures.Add(goblin1);
//        game.Creatures.Add(goblin2);
//        Assert.Equal(1, goblin1.Attack);
//        Assert.Equal(2, goblin1.Defense);
//        Assert.Equal(1, goblin2.Attack);
//        Assert.Equal(2, goblin2.Defense);
//        game.Creatures.Remove(goblin1);
//        Assert.Equal(1, goblin2.Attack);
//        Assert.Equal(1, goblin2.Defense);
//    }

//    [Fact]
//    public void Test3()
//    {
//        var game = new Game();
//        var goblinKing1 = new GoblinKing(game);
//        game.Creatures.Add(goblinKing1);
//        Assert.Equal(3, goblinKing1.Attack);
//        Assert.Equal(3, goblinKing1.Defense);
//    }

//    [Fact]
//    public void Test4()
//    {
//        var game = new Game();
//        var goblin1 = new Goblin(game);
//        var goblin2 = new Goblin(game);
//        var goblin3 = new Goblin(game);
//        game.Creatures.Add(goblin1);
//        game.Creatures.Add(goblin2);
//        game.Creatures.Add(goblin3);
//        Assert.Equal(1, goblin1.Attack);
//        Assert.Equal(3, goblin1.Defense);
//        Assert.Equal(1, goblin2.Attack);
//        Assert.Equal(3, goblin2.Defense);
//        Assert.Equal(1, goblin3.Attack);
//        Assert.Equal(3, goblin3.Defense);
//        var goblinKing1 = new GoblinKing(game);
//        game.Creatures.Add(goblinKing1);
//        Assert.Equal(2, goblin1.Attack);
//        Assert.Equal(4, goblin1.Defense);
//        Assert.Equal(2, goblin2.Attack);
//        Assert.Equal(4, goblin2.Defense);
//        Assert.Equal(2, goblin3.Attack);
//        Assert.Equal(4, goblin3.Defense);
//        Assert.Equal(3, goblinKing1.Attack);
//        Assert.Equal(6, goblinKing1.Defense);

//    }

//}