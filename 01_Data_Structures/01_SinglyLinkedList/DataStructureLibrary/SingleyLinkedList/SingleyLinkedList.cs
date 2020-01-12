using System;

namespace DataStructureLibrary.SingleyLinkedList
{
    public class SingleyLinkedList<T>
    {
        public SingleyLinkedList()
        {

        }

        public LinkedListNode<T> Head { get; set; }
        public int Count { get; private set; }

        public void Add(LinkedListNode<T> node)
        {
            if (node == null)
            {
                throw new ArgumentNullException();
            }

            if (this.Head == null)
            {
                this.Head = node;
            }
            else
            {
                var current = this.Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = node;
            }
            this.Count++;
        }

        public void Remove(LinkedListNode<T> node)
        {
            if (node == null || IsEmpty())
            {
                throw new InvalidOperationException();
            }

            if (this.Head == node)
            {
                this.Head = this.Head.Next;
                this.Count--;
            }
            else
            {
                var current = this.Head;

                while (current.Next != null)
                {
                    if (current.Next == node)
                    {
                        current.Next = node.Next;
                        this.Count--;
                    }
                    current = current.Next;
                }
            }
        }

        public void AddAfter(LinkedListNode<T> node, LinkedListNode<T> newNode)
        {
            if (node == null || IsEmpty())
            {
                throw new InvalidOperationException();
            }

            newNode.Next = node.Next;
            node.Next = newNode;
            this.Count++;
        }

        public LinkedListNode<T> GetNode(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException();
            }

            var current = this.Head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
    
            return current;
        }

        public bool IsEmpty()
        {
            return Head == null;
        }
    }
}
