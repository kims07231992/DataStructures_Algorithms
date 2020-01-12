using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG2_DynamicFibo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Run();
        }

        private static void Run()
        {
            Console.WriteLine("Please input a number for fibonacci");

            int n = Convert.ToInt32(Console.ReadLine());

            long result = DynamicProgramming.FiboCalculator.GetFibo(n);

            Console.WriteLine(result);
        }
    }
}
