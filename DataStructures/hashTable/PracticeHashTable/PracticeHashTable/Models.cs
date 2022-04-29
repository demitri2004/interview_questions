using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeHashTable
{
    class Models
    {
        public class Node
        {
            public Node Next { get; set; }
            public string Key { get; set; }
            public int Value { get; set; }
        }

        public class HashTable
        {
            private static Node[] _buckets;

            public HashTable(int size)
            {
                _buckets = new Node[size];
            }

            public void Add(string key, int value)
            {
                Node element = new Node() { Key = key, Value = value, Next = null };
                int index = HashFunction(key);
                Node nodeElement = _buckets[index];
                Node lastElement = null;

                if (nodeElement == null)
                    _buckets[index] = element;
                else
                {
                    lastElement = GetLastElementInIndex(index);
                    lastElement.Next = element;
                }
                    
            }

            public bool Delete(string key)
            {
                int index = HashFunction(key);
                Node elementToDelete = GetElementByKey(key);
                Node prevElement = getPrevElementFor(key);

                if (elementToDelete != null)
                {
                    if (elementToDelete.Next == null && prevElement == null)
                    {
                        _buckets[index] = null;
                        return true;
                    }
                    else
                    {                        
                        if(prevElement == null)
                        {
                            _buckets[index] = elementToDelete.Next;
                            return true;
                        }
                        else
                        {
                            prevElement.Next = elementToDelete.Next;
                            return true;
                        }
                    }
                   
                }
                return false;
            }

            private Node getPrevElementFor(string key)
            {
                int index = HashFunction(key);
                Node curElement = _buckets[index];

                if (curElement.Key == key)
                {
                    return null;
                }
                else
                {
                    while (curElement.Next != null)
                    {
                        if (curElement.Next.Key == key)
                        {
                            return curElement;
                        }
                        else
                        {
                            curElement = curElement.Next;
                        }
                    }
                    return curElement;
                }
            }

            public Node Search(string key)
            {
                Node element = GetElementByKey(key);
                if (element != null)
                {
                    return element;
                }
                return null;
            }

            private Node GetElementByKey(string key)
            {
                int index = HashFunction(key);
                Node element = _buckets[index];

                if (element.Key == key)
                {
                    return element;
                }
                else
                {
                    while (element.Next != null)
                    {                        
                        if(element.Next.Key == key)
                        {
                            return element.Next;
                        }
                        else
                        {
                            element = element.Next;
                        }
                    }
                    if (element.Key == key)
                        return element;
                    else
                        return null;
                }                
            }

            private Node GetLastElementInIndex(int index)
            {
                Node element = _buckets[index];

                if(element.Next != null)
                {                    
                    while (element.Next != null)
                    {
                        element = element.Next;
                    }
                    return element;
                }
                else
                {
                    return element;
                }                
            }


            private static int HashFunction(string key)
            {
                int index = 0;
                index = key[0] % _buckets.Length;
                return index;
            }
        }
    }
}
