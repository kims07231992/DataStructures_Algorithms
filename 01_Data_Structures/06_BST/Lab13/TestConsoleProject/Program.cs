using System;
using System.Collections.Generic;
using DataStructures;

namespace TestConsoleProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            Run();
        }
        public static void Run()
        {
            TestBinarySearchTree();
            Console.WriteLine("\n\n\n");
            TestBST();
            Console.WriteLine("\n\n\n");
            TestIsBST();
        }

        public static void TestBinarySearchTree()
        {
            BinarySearchTree<int> myBST = new BinarySearchTree<int>();

            SetBinarySearchTree(myBST);
        }
        private static void SetBinarySearchTree(BinarySearchTree<int> myBST)
        {
            List<int> sortedBSTList = new List<int>();

            //Insert Test
            myBST.Insert(4);
            myBST.Insert(2);
            myBST.Insert(1);
            myBST.Insert(3);
            myBST.Insert(6);
            myBST.Insert(5);
            myBST.Insert(7);
            sortedBSTList = myBST.ToSortedList();
            ShowBinarySearchTree(sortedBSTList);

            //Remove Test
            Console.WriteLine("{0}", myBST.Remove(1).ToString());
            sortedBSTList = myBST.ToSortedList();
            ShowBinarySearchTree(sortedBSTList);

            //Search Test
            Console.WriteLine("Search 7 = {0}", myBST.Search(7).ToString());
        }
        private static void ShowBinarySearchTree(List<int> sortedBSTList)
        {
            foreach (int data in sortedBSTList)
            {
                Console.Write("{0} ", data);
            }
            Console.WriteLine();
        }

        public static void TestBST()
        {
            BST<int> myBST = new BST<int>();

            SetBST(myBST);
        }
        private static void SetBST(BST<int> myBST)
        {
            //Insert Test
            myBST.Insert(new BSTNode<int>(4));
            myBST.Insert(new BSTNode<int>(2));

            BSTNode<int> node1 = new BSTNode<int>(1); // for Remove() test
            myBST.Insert(node1);

            myBST.Insert(new BSTNode<int>(3));
            myBST.Insert(new BSTNode<int>(6));
            myBST.Insert(new BSTNode<int>(5));
            myBST.Insert(new BSTNode<int>(7));
            myBST.InOrderTraversal();
            Console.WriteLine();

            //Remove Test
            myBST.Remove(node1);
            myBST.InOrderTraversal();
            Console.WriteLine();

            //Search Test
            Console.WriteLine("Search 7 = {0}", myBST.Search(2));
        }

        public static void TestIsBST()
        {
            BinaryTree<int> myBT = new BinaryTree<int>();

            myBT.Root = new BinaryTreeNode<int>(3);
            myBT.Root.Left = new BinaryTreeNode<int>(2);
            myBT.Root.Right = new BinaryTreeNode<int>(5);
            myBT.Root.Left.Left = new BinaryTreeNode<int>(1);
            myBT.Root.Left.Right = new BinaryTreeNode<int>(4); //wrong node

            Console.WriteLine("IsBST() = {0}", IsBST(myBT.Root, GetMinKey(myBT.Root), GetMaxKey(myBT.Root)).ToString());
        }

        public static bool IsBST(BinaryTreeNode<int> node, int minKey, int maxKey)
        {
            if (node == null)
            {
                return true;
            }

            if (node.Key < minKey || node.Key > maxKey)
            {
                return false;
            }

            return IsBST(node.Left, minKey, node.Key) && IsBST(node.Right, node.Key, maxKey);            
        }
        private static int GetMinKey(BinaryTreeNode<int> node)
        {
            //Already checked node? in upper method
            while (node.Left != null)
            {
                if (node.Key > node.Left.Key)
                {
                    node = node.Left;
                }
            }
            return node.Key;
        }
        private static int GetMaxKey(BinaryTreeNode<int> node)
        {
            //Already checked node? in upper method
            while (node.Right != null)
            {
                if (node.Key < node.Right.Key)
                {
                    node = node.Right;
                }
            }
            return node.Key;
        }
    }
}
