using System.Collections.Generic;

namespace AlgorithmLibrary.DataStructures
{
    public class GraphNode<T>
    {
        public GraphNode(T data)
        {
            this.IsVisited = false;
            this.Data = data;
            this.AdjList = new List<GraphNode<T>>();
        }

        public bool IsVisited { get; set; }
        public int Low { get; set; }
        public int Discovery { get; set; }
        public T Data { get; set; }
        public GraphNode<T> ParentNode { get; set; }
        public List<GraphNode<T>> AdjList { get; set; } 
    }
}
