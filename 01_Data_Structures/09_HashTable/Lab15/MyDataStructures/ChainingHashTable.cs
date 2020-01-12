namespace MyDataStructures
{
    public class ChainingHashTable
    {
        private const int INITIAL_SIZE = 16;
        private int size;
        private Node[] buckets;

        public ChainingHashTable(int capacity)
        {
            this.size = capacity;
            this.buckets = new Node[size];
        }
        public ChainingHashTable() : this(INITIAL_SIZE)
        {

        }

        public object this[object key]
        {
            get
            {
                return this.Get(key);
            }
            set
            {
                this.Set(key, value);
            }
        }

        public void Set(object key, object value)
        {
            int index = HashFunction(key);
            if (buckets[index] == null)
            {
                buckets[index] = new Node(key, value);
            }
            else
            {
                Node newNode = new Node(key, value);
                newNode.Next = buckets[index];
                buckets[index] = newNode;
            }
        }
        public object Get(object key)
        {
            int index = HashFunction(key);

            if (buckets[index] != null)
            {
                for (Node n = buckets[index]; n != null; n = n.Next)
                {
                    if (n.Key.Equals(key))
                    {
                        return n.Value;
                    }
                }
            }
            return null;
        }

        protected virtual int HashFunction(object key)
        {
            char[] keyArray = key.ToString().ToCharArray();
            int sum = 0;

            //shift folding
            foreach (char ch in keyArray)
            {
                sum = sum + ch << 2;
            }
            return sum % this.size; //to avoid hashtable OutOfRange
        }
        protected virtual int HashFunction(object key, int segmentsSize)
        {
            int length = key.ToString().Length;
            int sum = 0;
            char[] keyArray;

            //folding
            for (int i = 0; i < length; i += segmentsSize)
            {
                if (length - i < segmentsSize) //length < segmentsSize || rest of segments < sementsSize
                {
                    keyArray = key.ToString().Substring(i, length - i).ToCharArray();
                }
                else //length >= sementSize
                {
                    keyArray = key.ToString().Substring(i, segmentsSize).ToCharArray();
                }

                //shift folding
                foreach (char ch in keyArray) //sum
                {
                    sum = sum + ch << 2;
                }
            }
            return sum % this.size; //to avoid hashtable OutOfRange
        }

        private class Node
        {
            public object Key { get; set; }
            public object Value { get; set; }
            public Node Next { get; set; }

            public Node(object key, object value)
            {
                this.Key = key;
                this.Value = value;
                this.Next = null;
            }
        }
    }
}
