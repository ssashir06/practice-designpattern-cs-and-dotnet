using System;
using System.Numerics;

namespace Coding.Exercise
{
    public interface IDiscriminantStrategy
    {
        double CalculateDiscriminant(double a, double b, double c);
    }

    public class OrdinaryDiscriminantStrategy : IDiscriminantStrategy
    {
        public double CalculateDiscriminant(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }
    }

    public class RealDiscriminantStrategy : IDiscriminantStrategy
    {
        // todo (return NaN on negative discriminant!)
        public double CalculateDiscriminant(double a, double b, double c)
        {
            var val = b * b - 4 * a * c;
            if (val < 0)
            {
                return double.NaN;
            }
            else
            {
                return val;
            }
        }
    }

    public class QuadraticEquationSolver
    {
        private readonly IDiscriminantStrategy strategy;

        public QuadraticEquationSolver(IDiscriminantStrategy strategy)
        {
            this.strategy = strategy;
        }

        public Tuple<Complex, Complex> Solve(double a, double b, double c)
        {
            var d = this.strategy.CalculateDiscriminant(a, b, c);
            return Tuple.Create(
                (-b + Complex.Sqrt(d)) / (2 * a), 
                (-b - Complex.Sqrt(d)) / (2 * a));
        }
    }
}