using AlgorithmLibrary.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmLibrary.Algorithms
{
    public static class ArticulationPoint<T>
    {

        private static void Traverse(GraphNode<T> currentNode, int time, GraphNode<T> rootNode, HashSet<GraphNode<T>> articulationPoints)
        {
            int children = 0;

            currentNode.IsVisited = true;
            currentNode.Discovery = currentNode.Low = ++time;

            foreach (var adjNode in currentNode.AdjList)
            {
                if (!adjNode.IsVisited)
                {
                    children++;
                    adjNode.ParentNode = currentNode;
                    Traverse(adjNode, time, rootNode, articulationPoints);

                    currentNode.Low = Math.Min(currentNode.Low, adjNode.Low);

                    if (currentNode == rootNode && children > 1) // this means root node is in the middle of other group of nodes
                        articulationPoints.Add(currentNode);
                    else if (currentNode != rootNode && adjNode.Low >= currentNode.Discovery) // backward with single path
                        articulationPoints.Add(currentNode);
                }
                else if (adjNode != currentNode.ParentNode) // visited and not backward
                {
                    // mark with adj's discovery since this could be the it's value depends on the direction
                    currentNode.Low = Math.Min(currentNode.Low, adjNode.Discovery);
                }
            }
        }

        public static List<GraphNode<T>> FindArticulationPoints(Graph<T> graph)
        {
            int time = 0;
            var root = graph.VertexList.First();
            var articulationPoints = new HashSet<GraphNode<T>>();
            foreach (var node in graph.VertexList)
            {
                if (!node.IsVisited)
                    Traverse(node, time, root, articulationPoints);
            }

            return articulationPoints.ToList();
        }
    }
}
