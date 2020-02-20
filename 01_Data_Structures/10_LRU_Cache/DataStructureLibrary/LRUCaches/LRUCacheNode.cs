
namespace DataStructureLibrary.LRUCaches
{
    public class LRUCacheNode
    {
        public LRUCacheNode Prev { get; set; }
        public LRUCacheNode Next { get; set; }
        public int Key { get; set; }
        public int Value { get; set; }

        public LRUCacheNode(int key, int val)
        {
            this.Key = key;
            this.Value = val;
        }
    }
}
