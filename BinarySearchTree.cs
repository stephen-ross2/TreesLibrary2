using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreesLibrary
{
    public class BinarySearchTree<T> : BinaryTree<T>
        where T : IComparable
    {
        public BinaryTreeNode<T> Contains(T data)
        {
            BinaryTreeNode<T>? node = Root;
            while (node != null)
            {
                int result = data.CompareTo(node.Data);
                if (result == 0) { return node; }
                else if (result < 0) { node = node.Left; }
                else { node = node.Right; }
            }
            return null;
        }
    }
}