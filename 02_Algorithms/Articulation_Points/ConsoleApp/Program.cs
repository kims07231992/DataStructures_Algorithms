using AlgorithmLibrary.Algorithms;
using AlgorithmLibrary.DataStructures;
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
            var graph = new Graph<int>();
            var node0 = new GraphNode<int>(0);
            var node1 = new GraphNode<int>(1);
            var node2 = new GraphNode<int>(2);
            var node3 = new GraphNode<int>(3);
            var node4 = new GraphNode<int>(4);
            var node5 = new GraphNode<int>(5);
            var node6 = new GraphNode<int>(6);

            graph.AddVertex(node0);
            graph.AddVertex(node1);
            graph.AddVertex(node2);
            graph.AddVertex(node3);
            graph.AddVertex(node4);
            graph.AddVertex(node5);
            graph.AddVertex(node6);

            graph.AddEdge(node0, node1);
            graph.AddEdge(node0, node2);
            graph.AddEdge(node1, node3);
            graph.AddEdge(node2, node3);
            graph.AddEdge(node2, node5);
            graph.AddEdge(node3, node4);
            graph.AddEdge(node5, node6);

            var articulationPoints = ArticulationPoint<int>.FindArticulationPoints(graph);
            foreach (var node in articulationPoints)
            {
                Console.Write($"[{node.Data}]");
            }
            Console.WriteLine();
        }
    }
}
