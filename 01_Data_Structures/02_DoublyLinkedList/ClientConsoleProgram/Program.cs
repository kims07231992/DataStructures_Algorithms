using DataStructureLibrary.DoublyLinkedList;
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
            var doublyLinkedList = new DoublyLinkedList<int>();
            var firstNode = new LinkedListNode<int>(10);
            var secondNode = new LinkedListNode<int>(20);
            var thirdNode = new LinkedListNode<int>(30);
            var forthNode = new LinkedListNode<int>(40);

            doublyLinkedList.Add(firstNode);
            doublyLinkedList.Add(secondNode);
            doublyLinkedList.Add(forthNode);
            doublyLinkedList.AddAfter(secondNode, thirdNode);
            doublyLinkedList.Remove(firstNode);

            PrintAllElements(doublyLinkedList);
        }

        private static void PrintAllElements(DoublyLinkedList<int> doublyLinkedList)
        {
            Console.Write($"Count: {doublyLinkedList.Count}, Elements: ");
            var current = doublyLinkedList.FirstNode;
            while (current != null)
            {
                Console.Write($"{current.Value} ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
