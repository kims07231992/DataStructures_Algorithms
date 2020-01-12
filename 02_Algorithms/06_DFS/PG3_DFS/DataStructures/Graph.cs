using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG3_DFS.DataStructures
{
    internal class Graph<T>
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
            // fromV -> toV
            fromV.AdjList.Add(toV);
            fromV.WeightList.Add(weight);

            if (directed) // fromV <-> toV
            {
                toV.AdjList.Add(fromV);
                toV.WeightList.Add(weight);
            }
        }
    }
}
