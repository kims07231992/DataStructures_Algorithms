using System;

namespace ClientConsoleProgram
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
            var queue = new DataStructureLibrary.Queue.Queue<int>();

            for (int i = 1; i <= size; i++)
            {
                queue.Enqueue(i);
            }

            for (int i = 1; i <= size; i++)
            {
                int result = queue.Dequeue();
                Console.Write($"{result} ");
            }
        }
    }
}
