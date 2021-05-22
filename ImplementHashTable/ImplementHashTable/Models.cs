using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementHashTable
{
    class Models
    {
        public class Node<T>
        {
            public Node<T> Next { get; set; }
            public string Key { get; set; }
            public T Value { get; set; }
        }

        public class HashTable<T>
        {
            private readonly Node<T>[] _buckets;

            public HashTable(int size)
            {
                _buckets = new Node<T>[size];
            }

            public T Get(string key)
            {
                ValidateKey(key);

                var(_, node) = GetNodeByKey(key);

                if (node == null) throw
                         new ArgumentNullException(
                             nameof(key), $"The key '{key}' is not found!");

                return node.Value;
            }
            public void Add(string key, T item)
            {
                ValidateKey(key);

                var valueNode = new Node<T> { Key = key, Value = item, Next = null };
                int position = GetBucketByKey(key);
                Node<T> listNode = _buckets[position];

                if (listNode == null)
                {
                    _buckets[position] = valueNode;
                }
                else
                {
                    while (listNode.Next != null)
                    {
                        listNode = listNode.Next;
                    }
                    listNode.Next = valueNode;
                }
            }

            public bool Remove(string key)
            {
                ValidateKey(key);
                int position = GetBucketByKey(key);

                var (previous, current) = GetNodeByKey(key);

                if (current == null) return false;
                if(previous == null)
                {
                    _buckets[position] = null;
                    return true;
                }

                previous.Next = current.Next;
                return true;
            }

            public bool ContainsKey(string key)
            {
                ValidateKey(key);

                var (_, node) = GetNodeByKey(key);
                return node != null;
            }

            protected (Node<T> previous, Node<T> current) GetNodeByKey(string key)
            {
                int position = GetBucketByKey(key);
                Node<T> listNode = _buckets[position];
                Node<T> previous = null;

                while(listNode != null)
                {
                    if (listNode.Key == key) return (previous, listNode);

                    previous = listNode;
                    listNode = listNode.Next;
                }
                return (null, null);
            }            

            protected void ValidateKey(string key)
            {
                if (string.IsNullOrEmpty(key))
                    throw new ArgumentNullException(nameof(key));
            }

            public int GetBucketByKey(string key)
            {
                var test = key[0];
                var result = key[0] % _buckets.Length;
                return result;

                //return Math.Abs(key.GetHashCode() % _buckets.Length);
            }
        }
    }
}
