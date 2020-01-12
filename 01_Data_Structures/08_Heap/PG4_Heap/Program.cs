using PG4_Heap.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG4_Heap
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Run();
        }

        private static void Run()
        {
            var ascendComparer = new AscendComparer();
            Heap heap = new Heap(ascendComparer);

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "quit")
                    break;

                int num = Convert.ToInt32(command);
                heap.Add(num);
                heap.PrintHeap();
            }

            heap.RemoveAll();
        }
    }
}
