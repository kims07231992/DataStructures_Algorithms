using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG3_BubbleSort.BubbleSort
{
    public static class BubbleSorter
    {
        public static void BubbleSort<T>(List<T> elements) where T : IComparable<T>
        {
            int endIndex = elements.Count - 1;
            bool swapped = true;
            
            for (int i = 0; i < elements.Count - 1; i++) // do as much as n-1
            {
                if (!swapped) // to avoid unnecessary loop
                    break;

                swapped = false; // set flag as false to escape loop
                for (int j = 0; j < endIndex; j++)
                {
                    if (elements[j].CompareTo(elements[j + 1]) > 0)
                    {
                        Swap(elements, j, j + 1);
                        swapped = true; // set flag as true to keep looping
                    }
                }
                endIndex--;
            }
        }

        public static void BubbleSort<T>(List<T> elements, IComparer<T> comparer)
        {
            int endIndex = elements.Count - 1;
            bool swapped = true;

            for (int i = 0; i < elements.Count - 1; i++) // do as much as n-1
            {
                if (!swapped) // to avoid unnecessary loop
                    break;

                swapped = false; // set flag as false to escape loop
                for (int j = 0; j < endIndex; j++)
                {
                    if (comparer.Compare(elements[j], elements[j + 1]) > 0)
                    {
                        Swap(elements, j, j + 1);
                        swapped = true;
                    }
                }
                endIndex--;
            }
        }
        public static void BubbleSort<T>(List<T> elements, Comparison<T> comparison)
        {
            int endIndex = elements.Count - 1;
            bool swapped = true;

            for (int i = 0; i < elements.Count - 1; i++) // do as much as n-1
            {
                if (!swapped) // to avoid unnecessary loop
                    break;

                swapped = false; // set flag as false to escape loop
                for (int j = 0; j < endIndex; j++)
                {
                    if (comparison(elements[j], elements[j + 1]) > 0)
                    {
                        Swap(elements, j, j + 1);
                        swapped = true;
                    }
                }
                endIndex--;
            }
        }

        private static void Swap<T>(List<T> elements, int i, int j)
        {
            var temp = elements[i];
            elements[i] = elements[j];
            elements[j] = temp;
        }
    }
}
