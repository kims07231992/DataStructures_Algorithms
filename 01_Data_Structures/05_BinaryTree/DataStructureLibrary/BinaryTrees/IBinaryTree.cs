
namespace DataStructureLibrary.BinaryTrees
{
    public interface IBinaryTree<T>
    {
        BinaryTreeNode<T> Root { get; set; }

        void PreOrderTraversal();
        void InOrderTraversal();
        void PostOrderTraversal();
        void LevelOrderTraversal();
        int Count();
        bool IsEmpty();
    }
}
