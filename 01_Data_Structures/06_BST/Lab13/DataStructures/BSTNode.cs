namespace DataStructures
{
    public class BSTNode<T>
    {
        public BSTNode(T key)
        {
            Key = key;
            Left = null;
            Right = null;
        }

        internal BSTNode<T> Left { get; set; }
        internal BSTNode<T> Right { get; set; }
        public T Key { get; set; }
        public T Value { get; set; }
    }
}
