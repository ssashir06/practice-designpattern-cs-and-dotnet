using Coding.Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Coding.Exercise;

public class UnitTestIterator
{
    [Fact]
    public void Test1()
    {
        var root = new Node<int>(1, new Node<int>(2), new Node<int>(3));
        var preOrderTreeTraversal = root.PreOrder.ToArray();
        Assert.Equal(1, preOrderTreeTraversal[0]);
        Assert.Equal(2, preOrderTreeTraversal[1]);
        Assert.Equal(3, preOrderTreeTraversal[2]);
    }
}