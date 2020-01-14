
namespace DataStructureLibrary.Stacks.NodeBasedStack
{
    public class StackNode<T>
    {
        public StackNode(T value)
        {
            this.Value = value;
        }

        public T Value { get; set; }
        public StackNode<T> Next { get; set; }
    }
}
