using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public BinarySearchTree()
        {
            Root = null;
        }

        public BinaryTreeNode<T> Root { get; private set; }

        public void Insert(T key) //새 Key 데이타(T)를 BST 에 추가
        {
            BinaryTreeNode<T> newNode = new BinaryTreeNode<T>(key);

            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                InsertRecursive(Root, newNode);
            }
        }
        private void InsertRecursive(BinaryTreeNode<T> node, BinaryTreeNode<T> newNode)
        {
            int comp = node.Key.CompareTo(newNode.Key);

            if (comp == 0) //This instance is equal to value.
            {
                throw new ArgumentException();
            }
            else if (comp > 0) //This instance is less than value.
            {
                if (node.Left == null)
                {
                    node.Left = newNode;
                }
                else
                {
                    InsertRecursive(node.Left, newNode);
                }
            }
            else //This instance is greater than value.
            {
                if (node.Right == null)
                {
                    node.Right = newNode;
                }
                else
                {
                    InsertRecursive(node.Right, newNode);
                }
            }
        }

        public bool Remove(T key)
        {
            if (Root == null)
            {
                return false;
            }
            else
            {
                BinaryTreeNode<T> prev = null;
                BinaryTreeNode<T> current = Root;

                FindNode(ref prev, ref current, key);
                if (current == null) //if there is no deleteNode
                {
                    return false;
                }
                RemoveNode(prev, current);

                return true;
            }
        }
        private void FindNode(ref BinaryTreeNode<T> prev, ref BinaryTreeNode<T> current, T key)
        {
            while (current != null)
            {
                int comp = current.Key.CompareTo(key);
                if (comp == 0)
                {
                    break;
                }
                else if (comp > 0)
                {
                    prev = current;
                    current = current.Left;
                }
                else
                {
                    prev = current;
                    current = current.Right;
                }
            }
        }
        private void RemoveNode(BinaryTreeNode<T> prev, BinaryTreeNode<T> current)
        {
            if (current.Left == null && current.Right == null)  // leaf
            {
                if (prev.Left == current)
                {
                    prev.Left = null;
                }
                else
                {
                    prev.Right = null;
                }
            }
            else if (current.Left != null && current.Right != null) // has both
            {
                // Find min node within the right nodes
                var min = current.Right;
                var pre = current;
                while (min.Left != null)
                {
                    pre = min;
                    min = min.Left;
                }

                // Copy min node data to current
                current.Key = min.Key;

                // And then remove min node
                if (pre.Left == min)
                {
                    pre.Left = min.Right;
                }
                else
                {
                    pre.Right = min.Right;
                }
                min.Right = null;
            }
            else // has one child
            {
                var child = (current.Left != null) ? current.Left : current.Right;
                current.Left = null;
                current.Right = null;

                if (prev.Left == current)
                {
                    prev.Left = child;
                }
                else
                {
                    prev.Right = child;
                }
            }
        }

        public bool Search(T key) //데이타를 탐색하여 있으면 true 를 리턴.
        {
            BinaryTreeNode<T> node = Root;

            while (node != null)
            {
                int comp = node.Key.CompareTo(key);

                if (comp == 0) //This instance is equal to value.
                {
                    return true;
                }
                else if (comp > 0) //This instance is less than value.
                {
                    node = node.Left;
                }
                else //This instance is greater than value.
                {
                    node = node.Right;
                }
            }

            return false;
        }

        public List<T> ToSortedList() //소트 정렬된 트리 데이타를 List<T> 형태로 리턴
        {
            if (Root == null)
            {
                throw new InvalidProgramException();
            }
            List<T> sortedBSRList = new List<T>();

            ToSortedListRecursive(sortedBSRList, Root);

            return sortedBSRList;
        }
        private void ToSortedListRecursive(List<T> sortedBSRList, BinaryTreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }
            else
            {
                ToSortedListRecursive(sortedBSRList, node.Left);
                sortedBSRList.Add(node.Key);
                ToSortedListRecursive(sortedBSRList, node.Right);
            }
        }
    }
}
