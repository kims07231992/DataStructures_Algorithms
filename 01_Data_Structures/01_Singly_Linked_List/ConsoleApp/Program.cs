using DataStructureLibrary.SinglyLinkedList;
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
            var singleyLinkedList = new SinglyLinkedList<int>();
            var firstNode = new SinglyLinkedListNode<int>(10);
            var secondNode = new SinglyLinkedListNode<int>(20);
            var thirdNode = new SinglyLinkedListNode<int>(30);
            var forthNode = new SinglyLinkedListNode<int>(40);

            singleyLinkedList.Add(firstNode);
            singleyLinkedList.Add(thirdNode);
            singleyLinkedList.Add(forthNode);
            singleyLinkedList.AddAfter(firstNode, secondNode);
            singleyLinkedList.Remove(firstNode);

            PrintAllElements(singleyLinkedList);
        }

        private static void PrintAllElements(SinglyLinkedList<int> singleyLinkedList)
        {
            Console.Write($"Count: {singleyLinkedList.Count}, Elements: ");
            var current = singleyLinkedList.Head;
            while (current != null)
            {
                Console.Write($"[{current.Value}]");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
