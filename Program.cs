using Accord.Collections;
using com.sun.source.tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraverseBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            var tree = binaryTree.CreateBinaryTree(binaryTree);

            
            Console.WriteLine("\nPreOrder Traverse.");
            tree.preOrderTraverse();

            Console.WriteLine("\nInorder Traverse.");
            tree.inOrderTraverse();

            Console.WriteLine("\nPostorder Traverse.");
            tree.postOrderTraverse();

            Console.WriteLine("\nPress any key to end.");
            Console.ReadKey(true);

        }
    }
}
