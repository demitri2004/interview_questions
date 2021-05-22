using System;
using static ImplementHashTable.Models;

namespace ImplementHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var hashTable = new HashTable<int>(4);

            Console.WriteLine(hashTable.GetBucketByKey("ane"));


        }
    }
}
