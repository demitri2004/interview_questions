using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapImplement
{
    public class MinIntHeap
    {
        private int capacity = 10;
        private int size = 0;
        private int[] items;

        public MinIntHeap()
        {
            items = new int[capacity];
        }
         //getIdx
        private int getLeftChildIdx(int parentIdx)
        {
            return 2 * parentIdx + 1;
        }
        private int getRightChildIdx(int parentIdx)
        {
            return 2 * parentIdx + 2;
        }
        private int getParentIdx(int childIdx)
        {
            return (childIdx - 1) / 2;
        }
        //hasChild-Parent
        private bool hasLeftChild(int idx)
        {
            return getLeftChildIdx(idx) < size;
        }
        private bool hasRightChild(int idx)
        {
            return getRightChildIdx(idx) < size;
        }
        private bool hasParent(int idx)
        {
            return getParentIdx(idx) >= 0;
        }
        //getItem
        private int leftChild(int idx)
        {
            return items[getLeftChildIdx(idx)];
        }
        private int rightChild(int idx)
        {
            return items[getRightChildIdx(idx)];
        }
        private int parent(int idx)
        {
            return items[getParentIdx(idx)];
        }
        //swap & check capacity
        private void swap(int idxOne, int idxTwo)
        {
            int temp = items[idxOne];
            items[idxOne] = items[idxTwo];
            items[idxTwo] = temp;
        }
        private void ensureExtraCapacity()
        {
            if(size == capacity)
            {
                Array.Resize(ref items, capacity * 2);
                //int[] newArray = new int[capacity * 2];
                //Array.Copy(items, newArray, capacity * 2);
                capacity *= 2;
            }
        }
        //peek poll add
        public int peek()
        {
            if(size == 0)
            {
                throw new Exception();
            }
            return items[0];
        }
        public int pool()
        {
            if (size == 0)
            {
                throw new Exception();
            }
            int item = items[0];
            items[0] = items[size - 1];
            size--;
            heapifyDown();
            return item;
        }
        public void add(int item)
        {
            ensureExtraCapacity();
            items[size] = item;
            size++;
            heapifyUp();
        }
        //heapify
        public void heapifyUp()
        {
            int idx = size - 1;
            while (hasParent(idx) && parent(idx) > items[idx])
            {
                swap(getParentIdx(idx), idx);
                idx = getParentIdx(idx);
            }
        }
        public void heapifyDown()
        {
            int idx = 0;
            while (hasLeftChild(idx))
            {
                int smallerChildIdx = getLeftChildIdx(idx);
                if(hasRightChild(idx) && rightChild(idx) < leftChild(idx))
                {
                    smallerChildIdx = getRightChildIdx(idx);
                }
                if(items[idx] < items[smallerChildIdx])
                {
                    break;
                }
                else
                {
                    swap(idx, smallerChildIdx);
                }
                idx = smallerChildIdx;
            }
        }

    }
}
