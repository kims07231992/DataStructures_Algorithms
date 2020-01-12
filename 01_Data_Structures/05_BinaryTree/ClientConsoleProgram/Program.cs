using DataStructureLibrary.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientConsoleProgram
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Run();
        }

        private static void Run()
        {
            var binaryTree = new BinaryTree<int>();
            binaryTree.Root = new BinaryTreeNode<int>(1);
            binaryTree.Root.Left = new BinaryTreeNode<int>(2);
            binaryTree.Root.Right = new BinaryTreeNode<int>(3);
            binaryTree.Root.Left.Left = new BinaryTreeNode<int>(4);
            binaryTree.Root.Left.Right = new BinaryTreeNode<int>(5);
            binaryTree.Root.Right.Left = new BinaryTreeNode<int>(6);
            binaryTree.Root.Right.Right = new BinaryTreeNode<int>(7);
            binaryTree.Root.Left.Left.Left = new BinaryTreeNode<int>(8);
            binaryTree.Root.Left.Left.Right = new BinaryTreeNode<int>(9);

            Console.WriteLine("PreOrder");
            binaryTree.PreOrderTraversal();

            Console.WriteLine("InOrder");
            binaryTree.InOrderTraversal();

            Console.WriteLine("PostOrder");
            binaryTree.PostOrderTraversal();

            Console.WriteLine("LevelOrder");
            binaryTree.LevelOrderTraversal();
        }
    }
}
