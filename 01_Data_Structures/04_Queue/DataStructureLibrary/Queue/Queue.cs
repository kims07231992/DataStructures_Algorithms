using System;

namespace DataStructureLibrary.Queue
{
    public class Queue<T>
    {
        private const int _defaultCapacity = 16;
        private T[] _array;
        private int _front;
        private int _rear;
        private int _count;

        public Queue()
        {
            this._array = new T[_defaultCapacity];
        }
        
        public void Enqueue(T value)
        {
            if (IsFull())
            {
                T[] newArray = new T[this._array.Length * 2];

                if (this._front < this._rear) // Full without Dequeue case
                {
                    Array.Copy(this._array, this._front, newArray, 0, this._array.Length);
                }
                else // Rear ahead front case
                {
                    Array.Copy(this._array, this._front, newArray, 0, _array.Length - this._front);
                    Array.Copy(this._array, 0, newArray, _array.Length - this._front, this._rear);
                }
                this._array = newArray;
                this._front = 0;
                this._rear = this._count;
            }

            this._array[this._rear] = value;
            this._rear = (this._rear + 1) % this._array.Length;
            this._count++;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException();
            }

            return this._array[this._front];
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException();
            }

            T result = _array[this._front];
            this._front = (this._front + 1) % _array.Length;
            this._count--;

            return result;
        }

        public bool IsEmpty()
        {
            return this._count == 0;
        }

        private bool IsFull()
        {
            return this._count >= this._array.Length - 1;
        }
    }
}
