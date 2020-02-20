using System.Collections.Generic;

namespace DataStructureLibrary.LRUCaches
{
    public class LRUCache
    {
        private int _count;
        private int _capacity;
        private LRUCacheNode _head;
        private LRUCacheNode _tail;
        private Dictionary<int, LRUCacheNode> _map = new Dictionary<int, LRUCacheNode>();

        public LRUCache(int capacity)
        {
            _capacity = capacity;
        }

        public int Get(int key)
        {
            if (!_map.ContainsKey(key))
                return -1;

            var node = _map[key];
            if (_head == node)
                return node.Value;
            else if (node == _tail)
                RemoveTail();
            else
                RemoveNode(node);

            MoveToHead(node);

            return _head.Value;
        }

        public void Put(int key, int value)
        {
            if (_map.ContainsKey(key))
            {
                var node = _map[key];
                node.Value = value;

                if (_head == node)
                    return;
                else if (node == _tail)
                    RemoveTail();
                else
                    RemoveNode(node);

                MoveToHead(node);
            }
            else
            {
                var node = new LRUCacheNode(key, value);
                _map.Add(key, node);
                if (_count == _capacity) // evicts
                {
                    MoveToHead(node);
                    _map.Remove(_tail.Key);
                    RemoveTail();
                }
                else
                {
                    if (_head == null) // count 0
                    {
                        _head = _tail = node;
                    }
                    else if (_head == _tail) // count 1
                    {
                        _tail.Prev = node;
                        node.Next = _tail;
                        _head = node;
                    }
                    else
                    {
                        MoveToHead(node);
                    }
                    _count++;
                }
            }
        }

        private void MoveToHead(LRUCacheNode node)
        {
            _head.Prev = node;
            node.Next = _head;
            node.Prev = null;
            _head = node;
        }

        private void RemoveNode(LRUCacheNode node)
        {
            var prev = node.Prev;
            var next = node.Next;
            if (prev != null)
            {
                prev.Next = next;
            }
            if (next != null)
            {
                next.Prev = prev;
            }
        }

        private void RemoveTail()
        {
            _tail = _tail.Prev;
            _tail.Next = null;
        }
    }
}
