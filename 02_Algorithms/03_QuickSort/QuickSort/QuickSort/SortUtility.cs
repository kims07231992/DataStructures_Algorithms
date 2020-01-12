using System;
using System.Collections.Generic;

namespace QuickSort
{
    //'================================================================================================================
    //' CLASS NAME  : Sort
    //'               1.<T>에 대해서 IComparable, IComparer, Comparison등의 Type으로 QuickSort를 지원한다.
    //'================================================================================================================
    public static class SortUtility
    {
        public static void QuickSort<T>(List<T> elements) where T : IComparable<T>
        {
            int startIndex = 0;
            int endIndex = elements.Count - 1;

            QuickSort(elements, startIndex, endIndex);
        }
        private static void QuickSort<T>(List<T> elements, int left, int right) where T : IComparable<T>
        {
            int i = left, j = right;

            Partitioning(elements, ref i, ref j);

            // Recursive calls
            if (left < j)
            {
                QuickSort(elements, left, j);
            }

            if (i < right)
            {
                QuickSort(elements, i, right);
            }
        }
        private static void Partitioning<T>(List<T> elements, ref int i, ref int j) where T : IComparable<T>
        {
            T pivot = elements[(i + j) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    Swap(elements, i, j);

                    i++;
                    j--;
                }
            }

        }

        public static void QuickSort<T>(List<T> elements, IComparer<T> comparer)
        {
            int startIndex = 0;
            int endIndex = elements.Count - 1;

            QuickSort(elements, comparer, startIndex, endIndex);
        }
        private static void QuickSort<T>(List<T> elements, IComparer<T> comparer ,int left, int right)
        {
            int i = left, j = right;            

            Partitioning(elements, comparer, ref i, ref j);

            // Recursive calls
            if (left < j)
            {
                QuickSort(elements, comparer, left, j);
            }

            if (i < right)
            {
                QuickSort(elements, comparer, i, right);
            }
        }
        private static void Partitioning<T>(List<T> elements, IComparer<T> comparer, ref int i, ref int j)
        {
            T pivot = elements[(i + j) / 2];

            while (i <= j)
            {
                while (comparer.Compare(elements[i], pivot) < 0)
                {
                    i++;
                }

                while (comparer.Compare(elements[j], pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    Swap(elements, i, j);

                    i++;
                    j--;
                }
            }
        }

        public static void QuickSort<T>(List<T> elements, Comparison<T> comparison)
        {
            int startIndex = 0;
            int endIndex = elements.Count - 1;

            QuickSort(elements, comparison, startIndex, endIndex);
        }
        private static void QuickSort<T>(List<T> elements, Comparison<T> comparison, int left, int right)
        {
            int i = left, j = right;

            Partitioning(elements, comparison, ref i, ref j);

            // Recursive calls
            if (left < j)
            {
                QuickSort(elements, comparison, left, j);
            }

            if (i < right)
            {
                QuickSort(elements, comparison, i, right);
            }
        }
        private static void Partitioning<T>(List<T> elements, Comparison<T> comparison, ref int i, ref int j)
        {
            T pivot = elements[(i + j) / 2];

            while (i <= j)
            {
                while (comparison(elements[i], pivot) < 0)
                {
                    i++;
                }

                while (comparison(elements[j], pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    Swap(elements, i, j);

                    i++;
                    j--;
                }
            }
        }

        private static void Swap<T>(List<T> elements, int i, int j)
        {
            T temp = elements[i];
            elements[i] = elements[j];
            elements[j] = temp;
        }     
    }
}
