using System;
using static ImplementHashTable.Models;

namespace ImplementHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var hashTable = new HashTable<int>(4);

            Console.WriteLine(hashTable.GetBucketByKey("one"));
            Console.WriteLine(hashTable.GetBucketByKey("two"));
            Console.WriteLine(hashTable.GetBucketByKey("three"));
            Console.WriteLine(hashTable.GetBucketByKey("four"));
            Console.WriteLine(hashTable.GetBucketByKey("five"));
            Console.WriteLine(hashTable.GetBucketByKey("six"));
            Console.WriteLine(hashTable.GetBucketByKey("seven"));

            Console.WriteLine("_____________Add");

            hashTable.Add("one", 1);
            hashTable.Add("two", 2);
            hashTable.Add("three", 3);
            hashTable.Add("four", 4);
            hashTable.Add("five", 5);
            hashTable.Add("six", 6);
            hashTable.Add("seven", 7);
            hashTable.Add("fuck", 666);

            Console.WriteLine("_____________Get");

            Console.WriteLine(hashTable.Get("one"));
            Console.WriteLine(hashTable.Get("fuck"));

            Console.WriteLine("_____________");

            try
            {
                Console.WriteLine(hashTable.Get("eight"));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("_____________Remove");

            Console.WriteLine(hashTable.Remove("three"));
            Console.WriteLine(hashTable.Remove("three"));

        }
    }
}
