
namespace DataStructureLibrary.SinglyLinkedList
{
    public class SinglyLinkedListNode<T>
    {
        public SinglyLinkedListNode(T value)
        {
            this.Value = value;
        }

        public SinglyLinkedListNode<T> Next { get; set; }

        public T Value { get; set; }
    }
}
