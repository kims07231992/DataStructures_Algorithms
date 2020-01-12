namespace DataStructures
{
    public class BinaryTreeNode<T>
    {
        public BinaryTreeNode(T key)
        {
            Key = key;
            Left = null;
            Right = null;
        }

        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }
        public T Key { get; set; }
    }
}
