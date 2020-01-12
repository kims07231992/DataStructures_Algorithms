using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureLibrary.BinaryTree
{
    public class BinaryTree<T>
    {
        public BinaryTree()
        {

        }

        public BinaryTreeNode<T> Root { get; set; }

        public void PreOrderTraversal()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException();
            }

            PreOrderRecursive(this.Root);
            Console.WriteLine('\n');
        }

        private void PreOrderRecursive(BinaryTreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }

            Console.Write($"{node.Value} ");
            PreOrderRecursive(node.Left);
            PreOrderRecursive(node.Right);
        }

        public void InOrderTraversal()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException();
            }

            InOrderRecursive(this.Root);
            Console.WriteLine('\n');
        }

        private void InOrderRecursive(BinaryTreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }

            InOrderRecursive(node.Left);
            Console.Write($"{node.Value} ");
            InOrderRecursive(node.Right);
        }

        public void PostOrderTraversal()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException();
            }

            PostOrderRecursive(this.Root);
            Console.WriteLine('\n');
        }

        private void PostOrderRecursive(BinaryTreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }

            PostOrderRecursive(node.Left);
            PostOrderRecursive(node.Right);
            Console.Write($"{node.Value} ");
        }

        public void LevelOrderTraversal()
        {
            var queue = new Queue<BinaryTreeNode<T>>();
            var node = Root;

            queue.Enqueue(Root);

            while (queue.Count != 0)
            {
                node = queue.Dequeue();
                Console.Write($"{node.Value} ");

                if (node.Left != null)
                {
                    queue.Enqueue(node.Left);
                }
                if (node.Right != null)
                {
                    queue.Enqueue(node.Right);
                }
            }
            Console.WriteLine('\n');
        }

        public int Count()
        {
            int i = 0;
            CountRecursive(this.Root, ref i);

            return i;
        }

        private void CountRecursive(BinaryTreeNode<T> node, ref int i)
        {
            if (node == null)
            {
                return;
            }

            i++;
            CountRecursive(node.Left, ref i);
            CountRecursive(node.Right, ref i);
        }

        public bool IsEmpty()
        {
            return this.Root == null;
        }
    }
}
