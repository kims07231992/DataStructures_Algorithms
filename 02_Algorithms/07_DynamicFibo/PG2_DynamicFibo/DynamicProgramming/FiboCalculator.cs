using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG2_DynamicFibo.DynamicProgramming
{
    public static class FiboCalculator
    {
        public static long GetFibo(int n) // O(n)
        {
            if (n < 0)
                throw new IndexOutOfRangeException();

            if (n < 2) // to avoid IndexOutOfRange Exception
                return n;

            int[] fiboTable = new int[n + 1];
            long result;

            // 0, 1, 1, 2, ...
            fiboTable[0] = 0;
            fiboTable[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                fiboTable[i] = fiboTable[i - 1] + fiboTable[i - 2];
            }
            result = fiboTable[n];

            return result;
        }
    }
}
