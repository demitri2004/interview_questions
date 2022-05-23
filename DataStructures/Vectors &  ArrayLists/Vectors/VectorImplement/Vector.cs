using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorImplement
{
    internal class Vector
    {
        int size = 0;
        int capacity = 1;
        int[] items;
        public Vector()
        {
            items = new int[capacity]; 
        }
        //helpers
        internal void increaseSize()
        {
            Array.Resize(ref items, capacity * 2);
            capacity *= 2;
        }
        internal void moveRight(int idx)
        {
            for(int j = size; j > idx; j--)
            {
                items[j] = items[j - 1];
            }
        }
        internal void moveLeft(int idx)
        {
            for(int j = idx; j < size; j++)
            {
                items[j] = items[j + 1];
            }
        }
        //actions
        public void add(int elem, int idx = -1)
        {
            if (size == capacity)
                increaseSize();

            if(idx >= 0)
            {
                moveRight(idx);
                items[idx] = elem;
                size++;
            }
            else
            {
                items[size] = elem;
                size++;
            }
        }

        public void remove(int idx = -1)
        {
            if(idx < 0)
            {
                items[size - 1] = 0;
            }
            else
            {
                moveLeft(idx);
            }
        }

        public void print()
        {
            foreach(var v in items)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("************8");
        }

    }
}
