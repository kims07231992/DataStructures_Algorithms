using PG3_DFS.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG3_DFS.Algorithms
{
    internal static class DFS<T>
    {
        public static void DepthFirstSearch(List<GraphNode<T>> vertexList)
        {
            foreach (var v in vertexList)
            {
                RecursiveDFS(v);
            }
        }

        private static void RecursiveDFS(GraphNode<T> vertex)
        {
            if (!vertex.VisitFlag)
            {
                VisitVertex(vertex);
            }
            foreach (var adjV in vertex.AdjList) // visit adjacent vertex
            {
                if (!adjV.VisitFlag)
                {
                    RecursiveDFS(adjV);
                }
            }
        }

        private static void VisitVertex(GraphNode<T> vertex)
        {
            vertex.VisitFlag = true;
            Console.WriteLine(vertex.Data);
        }
    }
}
