
namespace DataStructureLibrary.BSTs
{
    public class BinarySearchTreeNode<T>
    {
        public BinarySearchTreeNode(T key)
        {
            Key = key;
            Left = null;
            Right = null;
        }

        public BinarySearchTreeNode<T> Left { get; set; }
        public BinarySearchTreeNode<T> Right { get; set; }
        public T Key { get; set; }
        public T Value { get; set; }
    }
}
