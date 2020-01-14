
namespace DataStructureLibrary.Queues
{
    public interface IQueue<T>
    {
        void Enqueue(T value);
        T Peek();
        T Dequeue();
        bool IsEmpty();
    }
}
