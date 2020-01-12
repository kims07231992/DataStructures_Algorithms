using DataStructureLibrary.SingleyLinkedList;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var singleyLinkedList = new SingleyLinkedList<int>();
            var firstNode = new LinkedListNode<int>(10);
            var secondNode = new LinkedListNode<int>(20);
            var thirdNode = new LinkedListNode<int>(30);
            var forthNode = new LinkedListNode<int>(40);

            singleyLinkedList.Add(firstNode);
            singleyLinkedList.Add(thirdNode);
            singleyLinkedList.Add(forthNode);
            singleyLinkedList.AddAfter(firstNode, secondNode);
            singleyLinkedList.Remove(firstNode);

            PrintAllElements(singleyLinkedList);
        }

        private static void PrintAllElements(SingleyLinkedList<int> singleyLinkedList)
        {
            Console.Write($"Count: {singleyLinkedList.Count}, Elements: ");
            var current = singleyLinkedList.Head;
            while (current != null)
            {
                Console.Write($"{current.Value} ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
