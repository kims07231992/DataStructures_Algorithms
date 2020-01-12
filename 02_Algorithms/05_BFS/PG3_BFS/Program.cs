using PG3_BFS.Algorithms;
using PG3_BFS.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG3_BFS
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            RunBFS();
        }

        private static void RunBFS()
        {
            Graph<char> myGraph = new Graph<char>();

            GraphNode<char> nodeA = new GraphNode<char>('A');
            GraphNode<char> nodeB = new GraphNode<char>('B');
            GraphNode<char> nodeC = new GraphNode<char>('C');
            GraphNode<char> nodeD = new GraphNode<char>('D');
            GraphNode<char> nodeE = new GraphNode<char>('E');
            GraphNode<char> nodeF = new GraphNode<char>('F');
            GraphNode<char> nodeG = new GraphNode<char>('G');
            GraphNode<char> nodeP = new GraphNode<char>('P');
            GraphNode<char> nodeQ = new GraphNode<char>('Q');

            myGraph.AddVertex(nodeA);
            myGraph.AddVertex(nodeB);
            myGraph.AddVertex(nodeC);
            myGraph.AddVertex(nodeP);
            myGraph.AddVertex(nodeQ);
            myGraph.AddVertex(nodeD);
            myGraph.AddVertex(nodeE);
            myGraph.AddVertex(nodeF);
            myGraph.AddVertex(nodeG);

            myGraph.AddEdge(nodeA, nodeG, 1, true);
            myGraph.AddEdge(nodeA, nodeD, 2, true);
            myGraph.AddEdge(nodeA, nodeC, 3, true);
            myGraph.AddEdge(nodeG, nodeF, 4, true);
            myGraph.AddEdge(nodeC, nodeE, 1, true);
            myGraph.AddEdge(nodeC, nodeD, 2, true);
            myGraph.AddEdge(nodeD, nodeB, 3, true);
            myGraph.AddEdge(nodeE, nodeB, 4, true);
            myGraph.AddEdge(nodeP, nodeQ, 1, true);

            BFS<char>.BreadthFirstSearch(myGraph.VertexList);
        }
    }
}
