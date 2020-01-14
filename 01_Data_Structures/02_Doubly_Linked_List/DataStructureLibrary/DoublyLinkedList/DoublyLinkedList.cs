using System;

namespace DataStructureLibrary.DoublyLinkedList
{
    public class DoublyLinkedList<T> : IDoublyLinkedList<T>
    {
        public DoublyLinkedList()
        {

        }

        public int Count { get; private set; }
        public DoublyLinkedListNode<T> FirstNode { get; private set; }
        public DoublyLinkedListNode<T> LastNode { get; private set; }

        public void Add(DoublyLinkedListNode<T> node)
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

        public void AddAfter(DoublyLinkedListNode<T> node, DoublyLinkedListNode<T> newNode)
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

        public void Remove(DoublyLinkedListNode<T> node)
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

        public DoublyLinkedListNode<T> GetNode(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException();
            }

            DoublyLinkedListNode<T> current = this.FirstNode;
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
