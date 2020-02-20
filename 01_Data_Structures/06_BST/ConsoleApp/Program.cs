using DataStructureLibrary.BSTs;
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
            var binarySearchTree = new BinarySearchTree<int>();
            binarySearchTree.Insert(4);
            binarySearchTree.Insert(2);
            binarySearchTree.Insert(10);
        }
    }
}
