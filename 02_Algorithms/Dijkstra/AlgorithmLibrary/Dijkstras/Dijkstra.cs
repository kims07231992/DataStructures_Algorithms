using System;

namespace AlgorithmLibrary.Dijkstras
{
    public static class Dijkstra
    {
        public static int[] GetMinDistances(int[,] graph, int source)
        {
            var length = (int)Math.Sqrt(graph.Length); // graph.Length = vertices ^ 2
            var visited = new bool[length];
            var distances = new int[length];
            for (int i = 0; i < length; i++)
            {
                distances[i] = int.MaxValue;
            }
            distances[source] = 0;

            for (int i = 0; i < length - 1; i++)
            {
                int u = GetMinDistance(distances, visited);
                visited[u] = true;

                for (int v = 0; v < length; v++)
                {
                    if (!visited[v] 
                            && graph[u, v] != 0 
                            && distances[u] != int.MaxValue 
                            && distances[u] + graph[u, v] < distances[v])
                        distances[v] = distances[u] + graph[u, v];
                }
            }

            return distances;
        }

        private static int GetMinDistance(int[] dist, bool[] visited)
        {
            int min = int.MaxValue;
            int minIndex = -1;
            for (int i = 0; i < visited.Length; i++)
            {
                if (visited[i] == false && dist[i] <= min)
                {
                    min = dist[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }
    }
}
