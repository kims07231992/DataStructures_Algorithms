using System.Collections.Generic;

namespace DataStructureLibrary.Graphs
{
    public class GraphNode<T>
    {
        private List<GraphNode<T>> _adjList;
        private List<int> _weightList;

        public GraphNode(T value)
        {
            this.Value = value;
            this.IsVisited = false;
        }

        public T Value { get; set; }
        public bool IsVisited { get; set; }
        public List<GraphNode<T>> AdjList
        {
            get
            {
                _adjList = _adjList ?? new List<GraphNode<T>>();
                return _adjList;
            }
        }
        public List<int> WeightList
        {
            get
            {
                _weightList = _weightList ?? new List<int>();
                return _weightList;
            }
        }
    }
}
