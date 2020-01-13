
namespace DataStructureLibrary.SinglyLinkedList
{
    public interface ISinglyLinkedList<T>
    {
        SinglyLinkedListNode<T> Head { get; set; }
        int Count { get; }

        void Add(SinglyLinkedListNode<T> node);
        void Remove(SinglyLinkedListNode<T> node);
        void AddAfter(SinglyLinkedListNode<T> node, SinglyLinkedListNode<T> newNode);
        SinglyLinkedListNode<T> GetNode(int index);
        bool IsEmpty();
    }
}
