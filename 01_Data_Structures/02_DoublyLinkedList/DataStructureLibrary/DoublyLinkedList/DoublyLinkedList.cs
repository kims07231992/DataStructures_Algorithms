using System;

namespace DataStructureLibrary.DoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        public DoublyLinkedList()
        {

        }

        public int Count { get; private set; }
        public LinkedListNode<T> FirstNode { get; set; } 
        public LinkedListNode<T> LastNode { get; set; }

        public void Add(LinkedListNode<T> node)
        {
            if (node == null)
            {
                throw new ArgumentNullException();
            }

            if (IsEmpty())
            {
                this.FirstNode = this.LastNode = node;
            }
            else
            {
                this.LastNode.Next = node;
                node.Prev = this.LastNode;
                this.LastNode = this.LastNode.Next;
            }
            this.Count++;
        }

        public void AddAfter(LinkedListNode<T> node, LinkedListNode<T> newNode)
        {
            if (node == null || newNode == null)
            {
                throw new ArgumentNullException();
            }

            node.Next.Prev = newNode;
            newNode.Next = node.Next;
            newNode.Prev = node;
            node.Next = newNode;
            this.Count++;
        }

        public void Remove(LinkedListNode<T> node)
        {
            if (node == null || IsEmpty())
            {
                throw new InvalidOperationException();
            }

            if (this.FirstNode == node)
            {
                this.FirstNode = this.FirstNode.Next;
                this.FirstNode.Prev = this.FirstNode ?? null;
            }
            else if (this.LastNode == node)
            {
                this.LastNode = this.LastNode.Prev;
                this.LastNode.Next = this.LastNode ?? null;
            }
            else
            {
                node.Prev.Next = node.Next;
                node.Next.Prev = node.Prev;
            }
            this.Count--;
        }

        public LinkedListNode<T> GetNode(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException();
            }

            LinkedListNode<T> current = this.FirstNode;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }

            return current;
        }

        public bool IsEmpty()
        {
            return this.FirstNode == null;
        }
    }
}
