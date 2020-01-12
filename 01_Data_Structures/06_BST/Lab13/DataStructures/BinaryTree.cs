using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class BinaryTree<T>
    {
        public BinaryTree()
        {
            Root = null;
        }

        public BinaryTreeNode<T> Root { get; set; }

        public void PreOrderTraversal()
        {
            PreOrderRecursive(Root);
        }
        private void PreOrderRecursive(BinaryTreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }
            else
            {
                Console.Write(node.Key);
                PreOrderRecursive(node.Left);
                PreOrderRecursive(node.Right);
            }
        }

        public void InOrderTraversal()
        {
            InOrderRecursive(Root);
        }
        private void InOrderRecursive(BinaryTreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }
            else
            {
                InOrderRecursive(node.Left);
                Console.Write(node.Key);
                InOrderRecursive(node.Right);
            }
        }

        public void PostOrderTraversal()
        {
            PostOrderRecursive(Root);
        }
        private void PostOrderRecursive(BinaryTreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }
            else
            {
                PostOrderRecursive(node.Left);
                PostOrderRecursive(node.Right);
                Console.Write(node.Key);
            }
        }

        public void LevelOrderTraversal()
        {
            Queue<BinaryTreeNode<T>> q = new Queue<BinaryTreeNode<T>>();
            BinaryTreeNode<T> node = Root;

            q.Enqueue(Root);

            while (q.Count != 0)
            {
                node = q.Dequeue();
                Console.Write(node.Key);

                if (node.Left != null)
                {
                    q.Enqueue(node.Left);
                }
                if (node.Right != null)
                {
                    q.Enqueue(node.Right);
                }
            }
        }

        public int Count()
        {
            int i = 0;

            CountRecursive(Root, ref i);

            return i;
        }
        private void CountRecursive(BinaryTreeNode<T> node, ref int i)
        {
            if (node == null)
            {
                return;
            }
            else
            {
                i++;
                CountRecursive(node.Left, ref i);
                CountRecursive(node.Right, ref i);
            }
        }

        public bool IsEmpty()
        {
            return Root == null;
        }
    }
}
