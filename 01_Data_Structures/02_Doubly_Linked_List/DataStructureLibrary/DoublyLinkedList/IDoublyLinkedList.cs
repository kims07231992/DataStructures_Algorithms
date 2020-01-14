
namespace DataStructureLibrary.DoublyLinkedList
{
    public interface IDoublyLinkedList<T>
    {
        int Count { get; }
        DoublyLinkedListNode<T> FirstNode { get; }
        DoublyLinkedListNode<T> LastNode { get; }

        void Add(DoublyLinkedListNode<T> node);
        void AddAfter(DoublyLinkedListNode<T> node, DoublyLinkedListNode<T> newNode);
        void Remove(DoublyLinkedListNode<T> node);
        DoublyLinkedListNode<T> GetNode(int index);
        bool IsEmpty();
    }
}
