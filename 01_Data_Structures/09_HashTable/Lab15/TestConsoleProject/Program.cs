using MyDataStructures;
using System;

namespace TestConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }
        public static void Run()
        {
            HashTableTest();
        }
        public static void HashTableTest()
        {
            ChainingHashTable ht = new ChainingHashTable();

            //Set()
            ht.Set(123456, 100);
            ht.Set(654321, 200);
            ht.Set("ABC", 300);
            ht.Set("CBA", 400);

            //Get()
            Console.WriteLine("Get(CDE) = {0}", ht.Get("123456"));
            Console.WriteLine("Get(ABC) = {0}\n\n", ht.Get("ABC"));

            //Indexer set
            ht[1] = 500;
            ht[0.5] = 600;
            ht['A'] = 700;

            //Indexer get
            Console.WriteLine("ht[1] = {0}", ht[1]);
            Console.WriteLine("ht[0.5] = {0}", ht[0.5]);
        }
    }
}
