using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureLibrary.Stacks.ArrayBasedStack
{
    public class ArrayBasedStack<T> : IStack<T>
    {
        private const int _defaultCapacity = 16;
        private int _top;
        private T[] _array;

        public ArrayBasedStack()
        {
            this._top = -1;
            this._array = new T[_defaultCapacity];
        }

        public void Push(T value)
        {
            if (this._top >= this._array.Length - 1)
            {
                T[] newArray = new T[2 * this._array.Length];
                Array.Copy(this._array, 0, newArray, 0, this._array.Length);
                this._array = newArray;
            }
            this._array[++this._top] = value;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException();
            }

            return this._array[this._top];
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException();
            }

            T result = this._array[this._top--];
            this._array[this._top + 1] = default(T);
            return result;
        }

        public int Count()
        {
            return this._top + 1;
        }

        public bool IsEmpty()
        {
            return this._top == -1;
        }
    }
}
