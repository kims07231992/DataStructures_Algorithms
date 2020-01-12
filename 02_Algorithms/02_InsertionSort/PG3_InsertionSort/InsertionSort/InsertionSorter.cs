using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG3_InsertionSort.InsertionSort
{
    public static class InsertionSorter
    {
        public static void Sort<T>(List<T> elements) where T : IComparable<T>
        {
            for (int i = 1; i < elements.Count; i++)
            {
                T key = elements[i];
                int j = i - 1;

                while (j >= 0 && elements[j].CompareTo(key) > 0)
                {
                    elements[j + 1] = elements[j];
                    j--;
                }
                elements[j + 1] = key;
            }
        }
    }
}
