using System.Collections.Generic;

namespace DataStructureLibrary.Graphs
{
    public class Graph<T>
    {
        private List<GraphNode<T>> _vertexList;

        public Graph()
        {

        }

        public List<GraphNode<T>> VertexList
        {
            get
            {
                this._vertexList = this._vertexList ?? new List<GraphNode<T>>();
                return this._vertexList;
            }
        }

        public void AddVertex(GraphNode<T> newVertex)
        {
            this.VertexList.Add(newVertex);
        }

        public void AddEdge(GraphNode<T> fromV, GraphNode<T> toV, int weight, bool directed)
        {
            // Connecting from fromV to toV
            fromV.AdjList.Add(toV);
            fromV.WeightList.Add(weight);

            if (directed) // fromV <-> toV
            {
                // Connecting from toV to fromV
                toV.AdjList.Add(fromV);
                toV.WeightList.Add(weight);
            }
        }
    }
}
