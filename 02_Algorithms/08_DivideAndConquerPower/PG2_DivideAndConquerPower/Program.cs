using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG2_DivideAndConquerPower
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Run();
        }

        private static void Run()
        {
            int baseNum = 2;
            int expNum = 10;

            long result = DivideAndConquer.PowerCalculator.GetPow(baseNum, expNum);

            Console.WriteLine(result);
        }
    }
}
