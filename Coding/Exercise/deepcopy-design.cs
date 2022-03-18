using System;

namespace Coding.Exercise
{
    public interface IDeepCopyable<T> where T : new()
    {
        void CopyTo(T target);

        T DeepCopy();
        // public T DeepCopy()
        // {
        //     T t = new T();
        //     CopyTo(t);
        //     return t;
        // }
    }
    public class Point : IDeepCopyable<Point>
    {
        public int X, Y;

        public void CopyTo(Point target)
        {
            target.X = X;
            target.Y = Y;
        }

        public Point DeepCopy()
        {
            Point t = new Point();
            CopyTo(t);
            return t;
        }
    }

    public class Line : IDeepCopyable<Line>
    {
        public Point Start, End;

        public Line()
        {
            Start = new Point();
            End = new Point();
        }

        public void CopyTo(Line target)
        {
            Start.CopyTo(target.Start);
            End.CopyTo(target.End);
        }

        public Line DeepCopy()
        {
            Line t = new Line();
            CopyTo(t);
            return t;
        }
    }
}
