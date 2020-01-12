using System;

namespace DataStructureLibrary.Stacks.ListBasedStack
{
    public class ListBasedStack<T> : IStack<T>
    {
        private StackNode<T> _top;
        private int _count;

        public ListBasedStack()
        {

        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException();
            }

            return this._top.Value;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException();
            }

            var result = this._top;
            this._top = this._top.Next;
            this._count--;

            return result.Value;
        }

        public void Push(T value)
        {
            var node = new StackNode<T>(value);

            if (IsEmpty())
            {
                this._top = node;
            }
            else
            {
                node.Next = this._top;
                this._top = node;
            }
            this._count++;
        }

        public int Count()
        {
            return this._count;
        }

        public bool IsEmpty()
        {
            return this._top == null;
        }
    }
}
