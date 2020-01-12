using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG2_DivideAndConquerPower.DivideAndConquer
{
    public static class PowerCalculator
    {
        // O(log2n)
        public static long GetPow(int baseNum, int expNum)
        {
            if (expNum == 1)
                return baseNum;
            else if (baseNum == 0)
                return 1;

            if ((expNum & 1) == 0) // even case
            {
                long newBase = GetPow(baseNum, expNum / 2);
                return newBase * newBase;
            }
            else // odd case
            {
                long newBase = GetPow(baseNum, (expNum - 1) / 2);
                return newBase * newBase * baseNum;
            }
        }
    }
}
