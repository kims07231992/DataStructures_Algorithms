using System;

namespace DataStructureLibrary.BSTs
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        private BinarySearchTreeNode<T> Root { get; set; }

        public void Insert(T key)
        {
            var newNode = new BinarySearchTreeNode<T>(key);

            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                InsertRecursive(Root, newNode);
            }
        }

        private void InsertRecursive(BinarySearchTreeNode<T> node, BinarySearchTreeNode<T> newNode)
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

        private void InsertIterative(BinarySearchTreeNode<T> newNode)
        {
            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                var node = Root;

                while (node != null)
                {
                    int comp = node.Key.CompareTo(newNode.Key);

                    if (comp == 0) // This instance is equal to value.
                    {
                        throw new ArgumentException();
                    }
                    else if (comp > 0) // This instance is less than value.
                    {
                        if (node.Left == null)
                        {
                            node.Left = new BinarySearchTreeNode<T>(newNode.Key);
                            return;
                        }
                        else
                        {
                            node = node.Left;
                        }
                    }
                    else // This instance is greater than value.
                    {
                        if (node.Right == null)
                        {
                            node.Right = new BinarySearchTreeNode<T>(newNode.Key);
                            return;
                        }
                        else
                        {
                            node = node.Right;
                        }
                    }
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
                BinarySearchTreeNode<T> prev = null;
                BinarySearchTreeNode<T> current = Root;

                FindNode(ref prev, ref current, key);
                if (current == null) // if there is no deleteNode
                {
                    return false;
                }
                RemoveNode(prev, current);

                return true;
            }
        }

        private void FindNode(ref BinarySearchTreeNode<T> prev, ref BinarySearchTreeNode<T> current, T key)
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

        private void RemoveNode(BinarySearchTreeNode<T> prev, BinarySearchTreeNode<T> current)
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

        public bool Search(T key)
        {
            BinarySearchTreeNode<T> node = Root;

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
    }
}
