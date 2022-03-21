using System;
using System.Collections.Generic;

namespace Coding.Exercise
{
    public class Node<T>
    {
        public T Value;
        public Node<T>? Left, Right;
        public Node<T>? Parent;

        public Node(T value)
        {
            Value = value;
        }

        public Node(T value, Node<T> left, Node<T> right)
        {
            Value = value;
            Left = left;
            Right = right;

            left.Parent = right.Parent = this;
        }

        public IEnumerable<T> PreOrder
        {
            get
            {
                var node = this;
                var stack = new Stack<Node<T>>();
                stack.Push(node);
                while (stack.Count > 0)
                {
                    node = stack.Pop();
                    yield return node.Value;
                    if (node.Right != null)
                    {
                        stack.Push(node.Right);
                    }
                    if (node.Left != null)
                    {
                        stack.Push(node.Left);
                    }
                }
            }
        }
    }
}
