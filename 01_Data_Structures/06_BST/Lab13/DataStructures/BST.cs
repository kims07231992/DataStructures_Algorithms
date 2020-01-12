using System;

namespace DataStructures
{
    public class BST<T> where T : IComparable<T>
    {
        private BSTNode<T> Root { get; set; }

        public void Insert(BSTNode<T> newNode) //새 노드 (BSTNode<T>)를 BST 에 추가
        {
            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                BSTNode<T> node = Root;

                while (node != null)
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
                            node.Left = new BSTNode<T>(newNode.Key);
                            return;
                        }
                        else
                        {
                            node = node.Left;
                        }
                    }
                    else //This instance is greater than value.
                    {
                        if (node.Right == null)
                        {
                            node.Right = new BSTNode<T>(newNode.Key);
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

        public bool Remove(BSTNode<T> deleteNode) //BST에서 하나의 노드를 삭제
        {
            if (Root == null)
            {
                return false;
            }
            else
            {
                BSTNode<T> prev = null;
                BSTNode<T> current = Root;

                FindNode(ref prev, ref current, deleteNode);           
                if (current == null) //if there is no deleteNode
                {
                    return false;
                }
                RemoveNode(prev, current);

                return true;
            }
        }
        private void FindNode(ref BSTNode<T> prev, ref BSTNode<T> current, BSTNode<T> deleteNode)
        {
            while (current != null)
            {
                int comp = current.Key.CompareTo(deleteNode.Key);
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
        private void RemoveNode(BSTNode<T> prev, BSTNode<T> current)
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

        public BSTNode<T> Search(T key) //데이타(Key)를 탐색하여 있으면 해당 노드를 리턴, 없으면 null 리턴
        {
            if (Root == null)
            {
                return null;
            }
            else
            {
                BSTNode<T> node = SearchRecursive(Root, key);
                return node;
            }
        }
        private BSTNode<T> SearchRecursive(BSTNode<T> node, T key)
        {
            int result = node.Key.CompareTo(key);

            if ((node == null) || (result == 0)) // There is no equal value || This instance is equal to value.
            {
                return node;
            }
            else if (result > 0) //This instance is less than value.
            {
                return SearchRecursive(node.Left, key);
            }
            else //This instance is greater than value.
            {
                return SearchRecursive(node.Right, key);
            }
        }

        public void InOrderTraversal()
        {
            InOrderRecursive(Root);
        }
        private void InOrderRecursive(BSTNode<T> node)
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
    }
}
