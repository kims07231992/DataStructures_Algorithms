namespace DataStructureLibrary.Stacks
{
    public interface IStack<T>
    {
        void Push(T value);
        T Pop();
        T Peek();
        int Count();
        bool IsEmpty();
    }
}
