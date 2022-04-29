using System;
using static PracticeHashTable.Models;

namespace PracticeHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable hashtable = new HashTable(4);

            hashtable.Add("one", 1);
            hashtable.Add("two", 2);
            hashtable.Add("three", 3);
            hashtable.Add("thr", 4);
            hashtable.Add("tee", 5);                        

            hashtable.Delete("tee");

            var srch = hashtable.Search("tee");
            Console.Write(srch);
        }
    }
}
