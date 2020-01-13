using System;

namespace DataStructureLibrary.SinglyLinkedList
{
    public class SinglyLinkedList<T> : ISinglyLinkedList<T>
    {
        public SinglyLinkedList()
        {

        }

        public SinglyLinkedListNode<T> Head { get; set; }
        public int Count { get; private set; }

        public void Add(SinglyLinkedListNode<T> node)
        {
            if (node == null)
                throw new ArgumentNullException();

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

        public void Remove(SinglyLinkedListNode<T> node)
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

        public void AddAfter(SinglyLinkedListNode<T> node, SinglyLinkedListNode<T> newNode)
        {
            if (node == null || IsEmpty())
            {
                throw new InvalidOperationException();
            }

            newNode.Next = node.Next;
            node.Next = newNode;
            this.Count++;
        }

        public SinglyLinkedListNode<T> GetNode(int index)
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
