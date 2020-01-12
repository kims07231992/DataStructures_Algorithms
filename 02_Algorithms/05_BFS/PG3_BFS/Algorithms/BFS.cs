using PG3_BFS.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG3_BFS.Algorithms
{
    internal static class BFS<T>
    {
        public static void BreadthFirstSearch(List<GraphNode<T>> vertexList)
        {
            var queue = new Queue<GraphNode<T>>();

            foreach (GraphNode<T> v in vertexList)
            {
                v.VisitFlag = true;
                queue.Enqueue(v);

                while (queue.Count != 0)
                {
                    var tempV = queue.Dequeue();
                    VisitVertex(tempV);

                    foreach (var adjV in tempV.AdjList)
                    {
                        if (!adjV.VisitFlag)
                        {
                            adjV.VisitFlag = true;
                            queue.Enqueue(adjV);
                        }
                    }
                }
            }
        }

        private static void VisitVertex(GraphNode<T> vertex)
        {
            Console.WriteLine(vertex.Data);
        }
    }
}
