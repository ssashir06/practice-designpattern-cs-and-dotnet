using Coding.Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Coding.Exercise;

public class UnitTestStorategy
{
    [Fact]
    public void Test_Ordinary()
    {
        var calc = new QuadraticEquationSolver(new OrdinaryDiscriminantStrategy());
        Assert.Equal(Tuple.Create(new Complex(3, 0), new Complex(-1, 0)),
            calc.Solve(1, -2, -3));
        Assert.Equal(Tuple.Create(new Complex(1, 0), new Complex(-1.5, 0)),
            calc.Solve(2, 1, -3));
        Assert.Equal(Tuple.Create(new Complex(1, Math.Sqrt(2)), new Complex(1, -Math.Sqrt(2))),
            calc.Solve(1, -2, 3));
    }

    [Fact]
    public void Test_Real()
    {
        var calc = new QuadraticEquationSolver(new RealDiscriminantStrategy());
        Assert.Equal(Tuple.Create(new Complex(3, 0), new Complex(-1, 0)),
            calc.Solve(1, -2, -3));
        Assert.Equal(Tuple.Create(new Complex(1, 0), new Complex(-1.5, 0)),
            calc.Solve(2, 1, -3));
        Assert.Equal(Tuple.Create(Complex.NaN, Complex.NaN),
            calc.Solve(1, -2, 3));
    }
}