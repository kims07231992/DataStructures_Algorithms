using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG3_BFS.DataStructures
{
    internal class GraphNode<T>
    {
        private List<GraphNode<T>> _adjList;
        private List<int> _weightList;

        public GraphNode(T data)
        {
            this.Data = data;
            this.VisitFlag = false;
        }

        public T Data { get; set; }
        public bool VisitFlag { get; set; }
        public List<GraphNode<T>> AdjList
        {
            get
            {
                this._adjList = this._adjList ?? new List<GraphNode<T>>();
                return this._adjList;
            }
        }
        public List<int> WeightList
        {
            get
            {
                this._weightList = this._weightList ?? new List<int>();
                return this._weightList;
            }
        }
    }
}
