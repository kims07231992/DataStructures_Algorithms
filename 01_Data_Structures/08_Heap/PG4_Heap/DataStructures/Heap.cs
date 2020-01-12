using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG4_Heap.DataStructures
{
    public class Heap
    {
        private List<int> _heap = new List<int>();
        private IComparer<int> _comparer;

        public Heap(IComparer<int> comparer)
        {
            this._comparer = comparer;
        }

        public void Add(int value)
        {
            this._heap.Add(value);

            int i = this._heap.Count - 1;
            while (i > 0)
            {
                int parent = (i - 1) / 2;
                if (this._comparer.Compare(this._heap[parent], this._heap[i]) < 1)
                {
                    Swap(parent, i);
                    i = parent;
                }
                else
                {
                    break;
                }
            }
        }

        public int RemoveOne()
        {
            if (this._heap.Count == 0)
                throw new InvalidOperationException();

            int root = this._heap[0];

            // move last to first 
            // and remove last one
            this._heap[0] = this._heap[this._heap.Count - 1];
            this._heap.RemoveAt(this._heap.Count - 1);

            // bubble down
            int i = 0;
            int last = this._heap.Count - 1;
            while (i < last)
            {
                // get left child index
                int child = i * 2 + 1;

                // use right child if it is bigger                
                if (child < last &&
                    this._heap[child] < this._heap[child + 1]) // MinHeap에선 반대
                    child = child + 1;

                // if parent is bigger or equal, stop
                if (child > last ||
                   this._heap[i] >= this._heap[child]) // MinHeap에선 반대
                    break;

                // swap parent/child
                Swap(i, child);
                i = child;
            }

            return root;
        }

        private void Swap(int i, int j)
        {
            int t = this._heap[i];
            this._heap[i] = this._heap[j];
            this._heap[j] = t;
        }

        public void PrintHeap()
        {
            foreach (int n in this._heap)
            {
                Console.Write($"[{n}]");
            }
            Console.WriteLine();
        }

        public void RemoveAll()
        {
            while (this._heap.Count > 1)
            {
                int n = RemoveOne();
                Console.Write($"[{n}]");
            }
            Console.WriteLine();
        }
    }

    public class AscendComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y.CompareTo(x);
        }
    }

    public class DescendComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return x.CompareTo(y);
        }
    }
}
