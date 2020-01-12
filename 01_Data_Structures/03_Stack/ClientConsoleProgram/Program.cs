using DataStructureLibrary.Stacks;
using DataStructureLibrary.Stacks.ArrayBasedStack;
using DataStructureLibrary.Stacks.ListBasedStack;
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
            IStack<int> arrayBasedStack = new ArrayBasedStack<int>();
            Console.WriteLine("Array Based Stack Test");
            RunIStackTest(arrayBasedStack);

            IStack<int> listBasedStack = new ListBasedStack<int>();
            Console.WriteLine("List Based Stack Test");
            RunIStackTest(listBasedStack);
        }

        private static void RunIStackTest(IStack<int> stack)
        {
            int size = 32;

            Console.Write("Push: ");
            for (int i = 1; i <= size; i++)
            {
                stack.Push(i);
                Console.Write($"{i}, ");
            }
            Console.WriteLine();

            Console.WriteLine($"Peek: {stack.Peek()}, Count: {stack.Count()}");

            Console.Write("Pop: ");
            for (int i = 1; i <= size; i++)
            {
                Console.Write($"{stack.Pop()}, ");
            }
            Console.WriteLine('\n');
        }
    }
}
