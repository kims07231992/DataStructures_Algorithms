using System.Collections.Generic;

namespace AlgorithmLibrary.DataStructures
{
    public class Graph<T>
    {
        public Graph()
        {
            this.VertexList = new List<GraphNode<T>>();
        }

        public int VertexCount => this.VertexList.Count;
        public List<GraphNode<T>> VertexList { get; set; }

        public void AddVertex(GraphNode<T> newVertex)
        {
            this.VertexList.Add(newVertex);
        }

        public void AddEdge(GraphNode<T> fromV, GraphNode<T> toV)
        {
            fromV.AdjList.Add(toV); // fromV -> toV
            toV.AdjList.Add(fromV); // fromV <- toV
        }
    }
}
