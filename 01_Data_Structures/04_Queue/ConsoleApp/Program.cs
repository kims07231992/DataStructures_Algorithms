using DataStructureLibrary.Queues.ArrayBasedQueues;
using System;

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Run();
        }

        private static void Run()
        {
            int size = 32;
            var queue = new ArrayBasedQueue<int>();

            for (int i = 1; i <= size; i++)
            {
                queue.Enqueue(i);
            }

            for (int i = 1; i <= size; i++)
            {
                int result = queue.Dequeue();
                Console.Write($"[{result}]");
            }
        }
    }
}
