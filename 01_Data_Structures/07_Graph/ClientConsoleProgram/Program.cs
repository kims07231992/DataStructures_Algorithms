using DataStructureLibrary.Graphs;

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
            var graph = new Graph<char>();

            var nodeA = new GraphNode<char>('A');
            var nodeB = new GraphNode<char>('B');
            var nodeC = new GraphNode<char>('C');
            var nodeP = new GraphNode<char>('P');
            var nodeQ = new GraphNode<char>('Q');
            var nodeD = new GraphNode<char>('D');
            var nodeE = new GraphNode<char>('E');
            var nodeF = new GraphNode<char>('F');
            var nodeG = new GraphNode<char>('G');

            graph.AddVertex(nodeA);
            graph.AddVertex(nodeB);
            graph.AddVertex(nodeC);
            graph.AddVertex(nodeD);
            graph.AddVertex(nodeE);
            graph.AddVertex(nodeF);
            graph.AddVertex(nodeG);
            graph.AddVertex(nodeP);
            graph.AddVertex(nodeQ);

            graph.AddEdge(nodeA, nodeG, 1, true);
            graph.AddEdge(nodeA, nodeD, 2, true);
            graph.AddEdge(nodeA, nodeC, 3, true);
            graph.AddEdge(nodeG, nodeF, 4, true);
            graph.AddEdge(nodeC, nodeE, 1, true);
            graph.AddEdge(nodeC, nodeD, 2, true);
            graph.AddEdge(nodeD, nodeB, 3, true);
            graph.AddEdge(nodeE, nodeB, 4, true);
            graph.AddEdge(nodeP, nodeQ, 1, true);
        }
    }
}
