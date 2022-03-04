using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraverseBinaryTree
{
	/// <summary>
	/// Class creates binary tree structure and contains Pre-Order, In-Order, and Post-Order operations (tree walking).
	/// </summary>
    public class BinaryTree
    {
        Node root;

        public BinaryTree(int key)
        {
            root = new Node(key);
        }

        public BinaryTree()
        {
            root = null;
        }

        public BinaryTree CreateBinaryTree(BinaryTree tree)
        {
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.right.right = new Node(5);

            return tree;
        }

		public void postOrderTraverse(Node node)
		{
			if (node == null)
			{
				return;
			}

			postOrderTraverse(node.left);
			postOrderTraverse(node.right);
			Console.Write(node.key + " ");
		}

		public void inOrderTraverse(Node node)
		{
			if (node == null)
			{
				return;
			}

			inOrderTraverse(node.left);
			Console.Write(node.key + " ");
			inOrderTraverse(node.right);
		}

		public void preOrderTraverse(Node node)
		{
			if (node == null)
			{
				return;
			}
			
			Console.Write(node.key + " ");
			preOrderTraverse(node.left);
			preOrderTraverse(node.right);
		}

		// Wrappers over above recursive functions
		public void postOrderTraverse() { postOrderTraverse(root); }
		public void inOrderTraverse() { inOrderTraverse(root); }
		public void preOrderTraverse() { preOrderTraverse(root); }
	}
}
