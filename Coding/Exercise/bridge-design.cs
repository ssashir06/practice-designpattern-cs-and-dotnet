using System;

namespace Coding.Exercise
{
    public interface IRenderer
    {
        string RenderShape(string name);
    }

    public class VectorRenderer : IRenderer
    {
        public string RenderShape(string name) => $"Drawing {name} as lines";
    }

    public class RasterRenderer : IRenderer
    {
        public string RenderShape(string name) => $"Drawing {name} as pixels";
    }
    public abstract class Shape
    {
        public string Name { get; set; }
        internal IRenderer Renderer { get; }

        public Shape(IRenderer renderer)
        {
            Renderer = renderer;
            Name = "";
        }

        public override string ToString()
        {
            return Renderer.RenderShape(Name);
        }
    }

    public class Triangle : Shape
    {
        public Triangle(IRenderer renderer) : base(renderer)
        {
            Name = "Triangle";
        }
    }

    public class Square : Shape
    {
        public Square(IRenderer renderer) : base(renderer)
        {
            Name = "Square";
        }
    }
}

